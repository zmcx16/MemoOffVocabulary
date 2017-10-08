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
using System.Threading;

using Newtonsoft.Json;

namespace MemoOffVocabulary
{
    public partial class MemoOffForm : Form
    {
        enum tabcontrol1_page{ tabPageStudy = 0, tabPageAddWord=1 };

        bool IsInitial_completed = false;
        MemoOffObject oMemoOffObject;

        Point OrgThisSize,
              DifftabControlFormSize, DifftextBoxKeyword_sSize, DifftextBoxValueword_sSize, DifftextBoxKeyword_aSize, DifftextBoxValueword_aSize,
              DiffcomboBoxDeckLocation, DiffbuttonGoodLocation, DiffbuttonEasyLocation, DiffbuttonAgainLocation, DiffbuttonAddLocation, DiffbuttonClearLocation,
                                        DiffbuttonGoodSize, DiffbuttonEasySize, DiffbuttonAgainSize, DiffbuttonAddSize, DiffbuttonClearSize;

        private void MemoOffForm_Load(object sender, EventArgs e)
        {

        }

        void InitialTimeSetting()
        {
            timer_study.Interval = Global.AutoStudyInterval * 1000;
            timer_study.Enabled = Global.EnableAutoStudy;
        }

        public MemoOffForm()
        {
            InitializeComponent();

            if (!Directory.Exists(Global.Deck_path))
                Directory.CreateDirectory(Global.Deck_path);

            Global.ReadSettingToIni();

            oMemoOffObject = new MemoOffObject();
            UpdateComboBoxDeckList(0);
            DrawCard();

            if (oMemoOffObject.TTS_speechtype != Global.TTS_SpeechType_MappingTable[0].Key)
                DownloadTTSAll();

            InitialTimeSetting();

            IsInitial_completed = true;
            SaveControlsLocationSize();

        }

        public void SaveControlsLocationSize()
        {
            OrgThisSize = new Point(this.Width,this.Height);

            DifftabControlFormSize = new Point(this.Width - tabControlForm.Width, this.Height - tabControlForm.Height);
            DifftextBoxKeyword_sSize = new Point(this.Width - textBoxKeyword_s.Width, this.Height - textBoxKeyword_s.Height);
            DifftextBoxValueword_sSize = new Point(this.Width - textBoxValueword_s.Width, this.Height - textBoxValueword_s.Height);
            DifftextBoxKeyword_aSize = new Point(this.Width - textBoxKeyword_a.Width, this.Height - textBoxKeyword_a.Height);
            DifftextBoxValueword_aSize = new Point(this.Width - textBoxValueword_a.Width, this.Height - textBoxValueword_a.Height);

            DiffcomboBoxDeckLocation = new Point(this.Width - comboBoxDeck.Location.X, this.Height - comboBoxDeck.Location.Y);
            DiffbuttonGoodLocation = new Point(this.Width - buttonGood.Location.X, this.Height - buttonGood.Location.Y);
            DiffbuttonEasyLocation = new Point(this.Width - buttonEasy.Location.X, this.Height - buttonEasy.Location.Y);
            DiffbuttonAgainLocation = new Point(this.Width - buttonAgain.Location.X, this.Height - buttonAgain.Location.Y);
            DiffbuttonAddLocation = new Point(this.Width - buttonAdd.Location.X, this.Height - buttonAdd.Location.Y);
            DiffbuttonClearLocation = new Point(this.Width - buttonClear.Location.X, this.Height - buttonClear.Location.Y);

            DiffbuttonGoodSize = new Point(this.Width - buttonGood.Width, this.Height - buttonGood.Height);
            DiffbuttonEasySize = new Point(this.Width - buttonEasy.Width, this.Height - buttonEasy.Height);
            DiffbuttonAgainSize = new Point(this.Width - buttonAgain.Width, this.Height - buttonAgain.Height);
            DiffbuttonAddSize = new Point(this.Width - buttonAdd.Width, this.Height - buttonAdd.Height);
            DiffbuttonClearSize = new Point(this.Width - buttonClear.Width, this.Height - buttonClear.Height);
        }

        private void DownloadTTSAll()
        {
            List<Tuple<string, string, string>> KeywordPathSpeechtype_list = new List<Tuple<string, string, string>>();
            MemoOffObject oMemoOffObject_temp= new MemoOffObject();
            for (int i=0;i<oMemoOffObject_temp.lDeckList.Count;i++)
            {
                string DeckDir_Path = Global.Deck_path + oMemoOffObject_temp.lDeckList[i]+"\\";
                if (!Directory.Exists(DeckDir_Path))
                    Directory.CreateDirectory(DeckDir_Path);

                oMemoOffObject_temp.ReadDeck(i);
                foreach (KeyValuePair <long, DeckStructure> card in oMemoOffObject_temp.CurrentDeck)
                {
                    string CardFile_Path = DeckDir_Path + card.Value.keyword + "_" + oMemoOffObject_temp.TTS_speechtype+ ".mp3";
                    if (!File.Exists(CardFile_Path))
                        KeywordPathSpeechtype_list.Add(new Tuple<string, string, string>(card.Value.keyword, CardFile_Path, oMemoOffObject_temp.TTS_speechtype));
                }
            }

            if (KeywordPathSpeechtype_list.Count > 0)
                TTS.DownloadTTSThread(KeywordPathSpeechtype_list);
        }

        private void UpdateComboBoxDeckList(int select_index)
        {
            UpdateComboBoxDeckList();
            if (comboBoxDeck.Items.Count > 0 && select_index!=-1)
                comboBoxDeck.SelectedIndex = select_index;
            else if (select_index==-1)
                comboBoxDeck.SelectedIndex = 0;

        }

        private void UpdateComboBoxDeckList()
        {
            comboBoxDeck.Items.Clear();
            comboBoxDeck.BeginUpdate();
            foreach (string deck in oMemoOffObject.lDeckList)
            {
                comboBoxDeck.Items.Add(deck);
            }
            comboBoxDeck.EndUpdate();
        }

        public void PlayTTS(string SoundPath)
        {
            if (File.Exists(SoundPath))
            {
                WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
                Player.URL = SoundPath;
                Player.settings.volume = Global.SoundVolume;
                Player.controls.play();
            }
        }

        public void DrawCard()
        {
            if (oMemoOffObject.CurrentDeck.Count > 0)
            {
                textBoxKeyword_s.Text = oMemoOffObject.CurrentDeck.ElementAt(0).Value.keyword;
                textBoxValueword_s.Text = oMemoOffObject.CurrentDeck.ElementAt(0).Value.valueword;

                if (oMemoOffObject.TTS_speechtype != Global.TTS_SpeechType_MappingTable[0].Key)
                    PlayTTS(Global.Deck_path + oMemoOffObject.lDeckList[oMemoOffObject.CurrentDeckIndex] + "\\" + oMemoOffObject.CurrentDeck.ElementAt(0).Value.keyword + "_" + oMemoOffObject.TTS_speechtype + ".mp3");
            }
            else
            {
                textBoxKeyword_s.Text = "";
                textBoxValueword_s.Text = "";
            }
        }

        private void SetProcessTopMost()
        {
            Process[] process = Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            if (process.Length > 0)
            {
                win32API.BringProcessTopMost(process[0].MainWindowHandle);
            }
        }

        private void SetProcessBottom()
        {
            Process[] process = Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            if (process.Length > 0)
            {
                win32API.BringProcessBottom(process[0].MainWindowHandle);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (!oMemoOffObject.AddCardToDeck(textBoxKeyword_a.Text, textBoxValueword_a.Text))
                return;

            string CardFile_Path = Global.Deck_path + oMemoOffObject.lDeckList[oMemoOffObject.CurrentDeckIndex] + "\\" + textBoxKeyword_a.Text + "_" + oMemoOffObject.TTS_speechtype + ".mp3";
            TTS.DownloadTTSThread(textBoxKeyword_a.Text, CardFile_Path, oMemoOffObject.TTS_speechtype);

            textBoxKeyword_a.Text = "";
            textBoxValueword_a.Text = "";
        }

        private void tabControlForm_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tabControlForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlForm.SelectedIndex == (int)tabcontrol1_page.tabPageStudy)
            {
                timer_study.Enabled = Global.EnableAutoStudy;
                if (oMemoOffObject.CurrentDeck.Count>0 && textBoxKeyword_s.Text == "")
                    DrawCard();
            }
            else
                timer_study.Enabled = false;
        }

        private void ToolStripMenuItemCreateDeck_Click(object sender, EventArgs e)
        {
            StopAllTimer();
            StringBuilder NewDeck = new StringBuilder();

            SetProcessBottom();
            EditForm ef = new EditForm(NewDeck, "", "Create", "Cancel", "Create Deck");
            ef.ShowDialog();
            if (Global.EnableBringExeTop)
                SetProcessTopMost();

            if (NewDeck.ToString() == "")
                return;

            oMemoOffObject.lDeckList.Add(NewDeck.ToString());
            oMemoOffObject.WriteDefaultDeckTTS_speechtype(oMemoOffObject.lDeckList.Count - 1);
            oMemoOffObject.SaveDeckList();
            UpdateComboBoxDeckList(comboBoxDeck.SelectedIndex);
            DrawCard();
            StartAllTimer();
        }

        private void ManageDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopAllTimer();

            string Now_DeckName="";
            if(comboBoxDeck.SelectedIndex>=0)
                Now_DeckName = comboBoxDeck.SelectedItem.ToString();

            SetProcessBottom();
            ManageDeck md = new ManageDeck();
            md.ShowDialog();
            if (Global.EnableBringExeTop)
                SetProcessTopMost();

            oMemoOffObject.ReadDeckList();
            UpdateComboBoxDeckList();

            if (Now_DeckName!="")
                comboBoxDeck.SelectedIndex = comboBoxDeck.FindString(Now_DeckName);

            if (comboBoxDeck.SelectedIndex != -1)
                oMemoOffObject.ReadDeck(comboBoxDeck.SelectedIndex);
            else if (comboBoxDeck.Items.Count > 0)
            {
                comboBoxDeck.SelectedIndex = 0;
                oMemoOffObject.ReadDeck(comboBoxDeck.SelectedIndex);
            }

            DrawCard();

            StartAllTimer();
        }

        private void UpdateDeck_DrawCard(int sec, int min, int hour, int day)
        {
            StopAllTimer();
            if (oMemoOffObject.CurrentDeck.Count > 0)
            {
                oMemoOffObject.UpdateMemoDeck(sec, min, hour, day);
                DrawCard();
            }
            StartAllTimer();
        }
        private void timer_study_Tick(object sender, EventArgs e)
        {
            UpdateDeck_DrawCard(timer_study.Interval / 1000, 0, 0, 0);
        }
        private void buttonAgain_Click(object sender, EventArgs e)
        {
            UpdateDeck_DrawCard(0, Global.StudyAgainInterval, 0, 0);
        }
        private void buttonGood_Click(object sender, EventArgs e)
        {
            UpdateDeck_DrawCard(0, 0, Global.StudyGoodInterval, 0);
        }
        private void buttonEasy_Click(object sender, EventArgs e)
        {
            UpdateDeck_DrawCard(0, 0, 0, Global.StudyEasyInterval);
        }

        private void ParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopAllTimer();

            SetProcessBottom();
            SettingParameter sp = new SettingParameter();        
            sp.ShowDialog();
            InitialTimeSetting();
            if(Global.EnableBringExeTop)
                SetProcessTopMost();

            oMemoOffObject.GetCurrentDeckTTS_speechtype();
            if (oMemoOffObject.TTS_speechtype != Global.TTS_SpeechType_MappingTable[0].Key)
                DownloadTTSAll();

            StartAllTimer();
        }

        private void MemoOffForm_Resize(object sender, EventArgs e)
        {
            if(IsInitial_completed)
            {
                tabControlForm.Width = this.Width - DifftabControlFormSize.X;   tabControlForm.Height = this.Height - DifftabControlFormSize.Y;
                textBoxKeyword_s.Width = this.Width - DifftextBoxKeyword_sSize.X; textBoxKeyword_s.Height = this.Height - DifftextBoxKeyword_sSize.Y;
                textBoxValueword_s.Width = this.Width - DifftextBoxValueword_sSize.X; textBoxValueword_s.Height = this.Height - DifftextBoxValueword_sSize.Y;
                textBoxKeyword_a.Width = this.Width - DifftextBoxKeyword_aSize.X; textBoxKeyword_a.Height = this.Height - DifftextBoxKeyword_aSize.Y;
                textBoxValueword_a.Width = this.Width - DifftextBoxValueword_aSize.X; textBoxValueword_a.Height = this.Height - DifftextBoxValueword_aSize.Y;

                if (this.Width >= OrgThisSize.X)
                {
                    comboBoxDeck.Location = new Point(this.Width - DiffcomboBoxDeckLocation.X, comboBoxDeck.Location.Y);
                    buttonGood.Location = new Point(this.Width - DiffbuttonGoodLocation.X, this.Height - DiffbuttonGoodLocation.Y);
                    buttonEasy.Location = new Point(this.Width - DiffbuttonEasyLocation.X, this.Height - DiffbuttonEasyLocation.Y);
                    buttonAgain.Location = new Point(this.Width - DiffbuttonAgainLocation.X, this.Height - DiffbuttonAgainLocation.Y);
                    buttonAdd.Location = new Point(this.Width - DiffbuttonAddLocation.X, this.Height - DiffbuttonAddLocation.Y);
                    buttonClear.Location = new Point(this.Width - DiffbuttonClearLocation.X, this.Height - DiffbuttonClearLocation.Y);
                }
                else
                {
                    buttonGood.Location = new Point(textBoxKeyword_s.Location.X + textBoxKeyword_s.Width / 3, this.Height - DiffbuttonGoodLocation.Y);
                    buttonEasy.Location = new Point(textBoxKeyword_s.Location.X + textBoxKeyword_s.Width * 2 / 3, this.Height - DiffbuttonEasyLocation.Y);
                    buttonAgain.Location = new Point(textBoxKeyword_s.Location.X, this.Height - DiffbuttonAgainLocation.Y);

                    buttonAdd.Location = new Point(textBoxKeyword_a.Location.X, this.Height - DiffbuttonAddLocation.Y);
                    buttonClear.Location = new Point(textBoxKeyword_a.Location.X + textBoxKeyword_a.Width / 2, this.Height - DiffbuttonClearLocation.Y);
                }
            }
        }

        private void comboBoxDeck_SelectionChangeCommitted(object sender, EventArgs e)
        {
            oMemoOffObject.SaveDeck();
            oMemoOffObject.CurrentDeckIndex = comboBoxDeck.SelectedIndex;
            oMemoOffObject.ReadDeck();
            DrawCard();
        }

        private void StopAllTimer()
        {
            timer_study.Stop();
        }

        private void StartAllTimer()
        {
            if(Global.EnableAutoStudy)
                timer_study.Start();
        }

        private void MemoOffForm_Activated(object sender, EventArgs e)
        {
            if (Global.EnableBringExeTop)
                SetProcessTopMost();
        }

        private void MemoOffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            oMemoOffObject.SaveDeck();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxKeyword_a.Text = "";
            textBoxValueword_a.Text = "";
        }

        private void tabPageAddCard_Click(object sender, EventArgs e)
        {

        }

        private void MemoOffForm_ResizeEnd(object sender, EventArgs e)
        {
            if (IsInitial_completed)
            {
                if (this.Width < OrgThisSize.X)
                {
                    buttonGood.Width = textBoxKeyword_s.Width / 3 - 10;
                    buttonEasy.Width = textBoxKeyword_s.Width / 3 - 10;
                    buttonAgain.Width = textBoxKeyword_s.Width / 3 - 10;

                    buttonAdd.Width = textBoxKeyword_a.Width / 2 - 10;
                    buttonClear.Width = textBoxKeyword_a.Width / 2 - 10;
                }
            }
        }

    }
}
