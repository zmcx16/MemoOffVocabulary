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

namespace MemoOffVocabulary
{
    public partial class SettingParameter : Form
    {
        public SettingParameter()
        {
            InitializeComponent();

            textBoxAgain.Text = Global.StudyAgainInterval.ToString();
            textBoxGood.Text = Global.StudyGoodInterval.ToString();
            textBoxEasy.Text = Global.StudyEasyInterval.ToString();
            textBoxAutoStudyInterval.Text = Global.AutoStudyInterval.ToString();
            checkBoxEnableBringExeTop.Checked = Global.EnableBringExeTop;
            checkBoxAutoStudy.Checked = Global.EnableAutoStudy;
            trackBarSoundVolume.Value = Global.SoundVolume;
            checkBoxEnableTTS.Checked = Global.EnableTTS;

            for (int i = 0; i < Global.TTS_SpeechType_MappingTable.Length; i++)
            {
                comboBoxTTS_SpeechType.Items.Add(Global.TTS_SpeechType_MappingTable[i].Value);
                if (Global.TTS_speechtype == Global.TTS_SpeechType_MappingTable[i].Key)
                    comboBoxTTS_SpeechType.SelectedIndex=i;
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
            Global.EnableTTS = checkBoxEnableTTS.Checked;
            Global.TTS_speechtype = Global.TTS_SpeechType_MappingTable[comboBoxTTS_SpeechType.SelectedIndex].Key;

            Global.WriteSettingToIni();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
