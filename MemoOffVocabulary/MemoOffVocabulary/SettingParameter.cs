﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MemoOffVocabulary
{
    public partial class SettingParameter : Form
    {
        List<Tuple<string, int>> TTS_DecksSpeechType;

        public SettingParameter()
        {
            InitializeComponent();

            TTS_DecksSpeechType = new List<Tuple<string, int>>();

            textBoxAgain.Text = Global.StudyAgainInterval.ToString();
            textBoxGood.Text = Global.StudyGoodInterval.ToString();
            textBoxEasy.Text = Global.StudyEasyInterval.ToString();
            textBoxAutoStudyInterval.Text = Global.AutoStudyInterval.ToString();
            checkBoxEnableBringExeTop.Checked = Global.EnableBringExeTop;
            checkBoxAutoStudy.Checked = Global.EnableAutoStudy;
            trackBarSoundVolume.Value = Global.SoundVolume;


            ReadDeckListTocomboBoxDeckList();
            if (comboBoxDeckList.Items.Count>0)
            {
                ReadDeckTTS_SpeechType();
                comboBoxDeckList.SelectedIndex = 0;
                comboBoxTTS_SpeechType.SelectedIndex = TTS_DecksSpeechType[comboBoxDeckList.SelectedIndex].Item2;
            }

        }

        public void ReadDeckListTocomboBoxDeckList()
        {
            StringBuilder sDeckList = new StringBuilder();
            win32API.GetPrivateProfileString("Setting", "Deck_list", "", ref sDeckList, Global.Deck_path + "setting.ini");

            string[] temp = sDeckList.ToString().Split('\t');
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != "")
                {
                    comboBoxDeckList.Items.Add(temp[i]);
                }
            }
        }

        public void ReadDeckTTS_SpeechType()
        {
            for (int j = 0; j < Global.TTS_SpeechType_MappingTable.Length; j++)
            {
                comboBoxTTS_SpeechType.Items.Add(Global.TTS_SpeechType_MappingTable[j].Value);
            }

            for (int i = 0; i < comboBoxDeckList.Items.Count; i++)
            {
                StringBuilder DeckSpeechType = new StringBuilder();
                win32API.GetPrivateProfileString(comboBoxDeckList.GetItemText(comboBoxDeckList.Items[i]), "TTS_speechtype", "None", ref DeckSpeechType, Global.Deck_path + "setting.ini");

                for (int j = 0; j < Global.TTS_SpeechType_MappingTable.Length; j++)
                {
                    if (DeckSpeechType.ToString() == Global.TTS_SpeechType_MappingTable[j].Key)
                        TTS_DecksSpeechType.Add(new Tuple<string, int>(comboBoxDeckList.GetItemText(comboBoxDeckList.Items[i]), j));
                }
            }
        }

        bool CheckValid()
        {
            int temp_int = 0;
            
            int.TryParse(textBoxAgain.Text,out temp_int);
            if (!int.TryParse(textBoxAgain.Text, out temp_int) || temp_int <= 0)
                return false;

            int.TryParse(textBoxGood.Text, out temp_int);
            if (!int.TryParse(textBoxGood.Text, out temp_int) || temp_int <= 0)
                return false;

            int.TryParse(textBoxEasy.Text, out temp_int);
            if (!int.TryParse(textBoxEasy.Text, out temp_int) || temp_int <= 0)
                return false;

            int.TryParse(textBoxAutoStudyInterval.Text, out temp_int);
            if (!int.TryParse(textBoxAutoStudyInterval.Text, out temp_int) || temp_int <= 0)
                return false;

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (!CheckValid())
            {
                MessageBox.Show("Parameter invalid!!");
                return;
            }

            Global.StudyAgainInterval = int.Parse(textBoxAgain.Text);
            Global.StudyGoodInterval = int.Parse(textBoxGood.Text);
            Global.StudyEasyInterval = int.Parse(textBoxEasy.Text);
            Global.AutoStudyInterval = int.Parse(textBoxAutoStudyInterval.Text);
            Global.EnableBringExeTop = checkBoxEnableBringExeTop.Checked;
            Global.EnableAutoStudy = checkBoxAutoStudy.Checked;
            Global.SoundVolume = trackBarSoundVolume.Value;

            Global.WriteSettingToIni();
            WriteTTS_Setting();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingParameter_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxDeckList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxTTS_SpeechType.SelectedItem = Global.TTS_SpeechType_MappingTable[TTS_DecksSpeechType[comboBoxDeckList.SelectedIndex].Item2].Value;

        }

        private void comboBoxTTS_SpeechType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TTS_DecksSpeechType[comboBoxDeckList.SelectedIndex] = new Tuple<string, int>(TTS_DecksSpeechType[comboBoxDeckList.SelectedIndex].Item1, comboBoxTTS_SpeechType.SelectedIndex);
        }

        private void WriteTTS_Setting()
        {
            for (int i = 0; i < TTS_DecksSpeechType.Count; i++)
            {
                win32API.WritePrivateProfileString(TTS_DecksSpeechType[i].Item1, "TTS_speechtype", Global.TTS_SpeechType_MappingTable[TTS_DecksSpeechType[i].Item2].Key, Global.Deck_path + "setting.ini");
            }
        }
    }
}