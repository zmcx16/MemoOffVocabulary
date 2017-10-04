using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

using Newtonsoft.Json;

namespace MemoOffVocabulary
{
    public partial class MemoOffForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("USER32.DLL",SetLastError = true)]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        void BringProcessToTop(IntPtr hWnd)
        {
            IntPtr HWND_TOPMOST = new IntPtr(-1);
            uint SWP_NOACTIVATE = 0x0010;
            uint SWP_NOMOVE = 0x0002;
            uint SWP_NOSIZE = 0x0001;
            SetWindowPos(hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);
        }

        enum tabcontrol1_page{ tabPageStudy = 0, tabPageAddWord=1 };

        string group_path = Directory.GetCurrentDirectory() + "\\Group\\";
        SortedDictionary<long, DeckStructure> choose_memo_deck = new SortedDictionary<long, DeckStructure>();
        void get_group_list()
        {
            if (!Directory.Exists(group_path))
                Directory.CreateDirectory(group_path);

            List<string> group_directories = new List<string>();
            if (Directory.Exists(group_path))
                group_directories.AddRange(Directory.GetDirectories(group_path));

            comboBoxGroup.BeginUpdate();
            foreach (string dir in group_directories)
            {
                string dir_name = dir.Replace(group_path,"");
                comboBoxGroup.Items.Add(dir_name);
            }
            comboBoxGroup.EndUpdate();

            if (comboBoxGroup.Items.Count > 0)
                comboBoxGroup.SelectedIndex = 0;
        }


        private void MemoOffForm_Load(object sender, EventArgs e)
        {

        }

        public MemoOffForm()
        {
            InitializeComponent();
            get_group_list();

            read_deck(group_path + comboBoxGroup.Items[comboBoxGroup.SelectedIndex] + ".json");

            timer_BringExeTop.Enabled = true;
            timer_study.Enabled = true;

            Read_FirstCard();
        }

        public void Read_FirstCard() {

            if (choose_memo_deck.Count > 0)
            {
                textBoxKeyword_s.Text = choose_memo_deck.ElementAt(0).Value.keyword;
                textBoxValueword_s.Text = choose_memo_deck.ElementAt(0).Value.valueword;
            }

        }

        public void UpdateMemo_deck(long key, int sec, int min,int hour,int day)
        {
            DateTime dt = DateTime.ParseExact(key.ToString(), "yyyyMMddHHmmss", null);
            dt = dt.AddSeconds(sec); dt = dt.AddMinutes(min); dt = dt.AddHours(hour); dt = dt.AddDays(day);

            if (dt < DateTime.Now)
                dt = DateTime.Now;

            choose_memo_deck.Add( long.Parse(dt.ToString("yyyyMMddHHmmss")), new DeckStructure(choose_memo_deck[key].keyword, choose_memo_deck[key].valueword));     
            choose_memo_deck.Remove(key);
        }

        public void read_deck(string deck_path)
        {
            if (File.Exists(deck_path))
            {
                StringBuilder deck_file = new StringBuilder(File.ReadAllText(deck_path));
                choose_memo_deck = JsonConvert.DeserializeObject<SortedDictionary<long, DeckStructure>>(deck_file.ToString());
            }
        }


        public void delay(int delay_milliseconds)
        {
            DateTime time_before = DateTime.Now;
            while (((TimeSpan)(DateTime.Now - time_before)).TotalMilliseconds < delay_milliseconds)
            {
                Application.DoEvents();
            }
        }

        private void timer_BringExeTop_Tick(object sender, EventArgs e)
        {
            Process []process = Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            if (process.Length>0) 
            {
                BringProcessToTop(process[0].MainWindowHandle);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string keyword = textBoxKeyword_a.Text;
            string valueword = textBoxValueword_a.Text;
            string json_path = group_path + comboBoxGroup.Items[comboBoxGroup.SelectedIndex] + ".json";
            string datetimeNow = DateTime.Now.ToString("yyyyMMddHHmmss");

            long key = long.Parse(datetimeNow);
            while (choose_memo_deck.ContainsKey(key))
            {
                DateTime dt = DateTime.ParseExact(key.ToString(), "yyyyMMddHHmmss", null);
                dt = dt.AddSeconds(1);
                key = long.Parse(dt.ToString("yyyyMMddHHmmss"));
            }
            choose_memo_deck.Add(key, new DeckStructure(keyword, valueword));
 
            string output = JsonConvert.SerializeObject(choose_memo_deck);
            File.WriteAllText(json_path, output);

            read_deck(group_path + comboBoxGroup.Items[comboBoxGroup.SelectedIndex] + ".json");
            textBoxKeyword_a.Text = "";
            textBoxValueword_a.Text = "";

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == (int)tabcontrol1_page.tabPageStudy)
                timer_study.Enabled = true;
            else
                timer_study.Enabled = false;
        }

        private void timer_study_Tick(object sender, EventArgs e)
        {
            if (choose_memo_deck.Count > 0)
            {
                UpdateMemo_deck(choose_memo_deck.ElementAt(0).Key, timer_study.Interval/1000, 0, 0, 0);
                Read_FirstCard();
            }
        }
    }
}
