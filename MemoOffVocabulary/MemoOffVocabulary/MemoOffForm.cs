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

        MemoOffObject oMemoOffObject;

        private void MemoOffForm_Load(object sender, EventArgs e)
        {

        }

        public MemoOffForm()
        {
            InitializeComponent();

            oMemoOffObject = new MemoOffObject();
            UpdateDeckList(0);
            DrawCard();
            timer_BringExeTop.Enabled = true;
            timer_study.Enabled = true;

        }

        private void UpdateDeckList(int select_index)
        {
            comboBoxDeck.Items.Clear();
            comboBoxDeck.BeginUpdate();
            foreach (string deck in oMemoOffObject.lDeckList)
            {
                comboBoxDeck.Items.Add(deck);
            }
            comboBoxDeck.EndUpdate();

            if (comboBoxDeck.Items.Count > 0)
                comboBoxDeck.SelectedIndex = select_index;
        }

        public void DrawCard()
        {
            if (oMemoOffObject.CurrentDeck.Count > 0)
            {
                textBoxKeyword_s.Text = oMemoOffObject.CurrentDeck.ElementAt(0).Value.keyword;
                textBoxValueword_s.Text = oMemoOffObject.CurrentDeck.ElementAt(0).Value.valueword;
            }
            else
            {
                textBoxKeyword_s.Text = "";
                textBoxValueword_s.Text = "";
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
                //win32API.BringProcessToTop(process[0].MainWindowHandle);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            oMemoOffObject.AddCardToDeck(textBoxKeyword_a.Text, textBoxValueword_a.Text);
            textBoxKeyword_a.Text = "";
            textBoxValueword_a.Text = "";
        }

        private void tabControlForm_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tabControlForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlForm.SelectedIndex == (int)tabcontrol1_page.tabPageStudy)
                timer_study.Enabled = true;
            else
                timer_study.Enabled = false;
        }

        private void comboBoxDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            oMemoOffObject.sCurrentDeckName = oMemoOffObject.lDeckList[comboBoxDeck.SelectedIndex];
            oMemoOffObject.ReadDeck();
            DrawCard();
        }

        private void menuStripForm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripMenuItemCreateDeck_Click(object sender, EventArgs e)
        {
            timer_study.Stop();
            StringBuilder NewDeck = new StringBuilder();
            EditForm ef = new EditForm(NewDeck, "Create", "Cancel", "Create Deck");
            ef.ShowDialog();
            if (NewDeck.ToString() == "")
                return;

            oMemoOffObject.lDeckList.Add(NewDeck.ToString());
            oMemoOffObject.SaveDeckList();
            UpdateDeckList(comboBoxDeck.SelectedIndex);
            DrawCard();
            timer_study.Start();
        }

        private void ManageDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_study.Stop();
            ManageDeck md = new ManageDeck();
            md.ShowDialog();
            UpdateDeckList(0);
            DrawCard();
            timer_study.Start();
        }

        private void UpdateDeck_DrawCard(int sec, int min, int hour, int day)
        {
            timer_study.Stop();
            if (oMemoOffObject.CurrentDeck.Count > 0)
            {
                oMemoOffObject.UpdateMemoDeck(sec, min, hour, day);
                DrawCard();
            }
            timer_study.Start();
        }
        private void timer_study_Tick(object sender, EventArgs e)
        {
            UpdateDeck_DrawCard(timer_study.Interval / 1000, 0, 0, 0);
        }
        private void buttonAgain_Click(object sender, EventArgs e)
        {
            UpdateDeck_DrawCard(0, oMemoOffObject.study_again, 0, 0);
        }
        private void buttonGood_Click(object sender, EventArgs e)
        {
            UpdateDeck_DrawCard(0, 0, oMemoOffObject.study_good, 0);
        }
        private void buttonEasy_Click(object sender, EventArgs e)
        {
            UpdateDeck_DrawCard(0, 0, 0, oMemoOffObject.study_easy);
        }

        private void ParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



    }
}
