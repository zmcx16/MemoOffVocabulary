using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace MemoOffVocabulary
{
    public partial class WebCrawlerForm : Form
    {
        MemoOffObject oMemoOffObject;
        bool bDownloading = false;
        Thread DownloadingThread;
        List<string> DownloadList;

        delegate void SetControlStringCallback(Control ControlObject, string SetValue);
        delegate void SetProgressBarIntCallback(ProgressBar pb, int SetValue);

        public WebCrawlerForm()
        {
            InitializeComponent();

            oMemoOffObject = new MemoOffObject();
            DownloadList = new List<string>();

            LoadDeckList();

            for (int i = 0; i < Translation.TransMappingTable.Count; i++)
                comboBoxParseSource.Items.Add(Translation.TransMappingTable.Keys.ElementAt(i));

            comboBoxParseSource.SelectedIndex = 0;
        }
        private void LoadDeckList()
        {
            foreach (string s in oMemoOffObject.lDeckList)
            {
                comboBoxDeck.Items.Add(s);
            }
            if (comboBoxDeck.Items.Count > 0)
                comboBoxDeck.SelectedIndex = 0;
        }

        void SetControlEnable(bool set_value)
        {
            this.Invoke(new Func<bool>(() => this.buttonDownload.Enabled = set_value));
            this.Invoke(new Func<bool>(() => this.buttonBack.Enabled = set_value));
            this.Invoke(new Func<bool>(() => this.comboBoxDeck.Enabled = set_value));
            this.Invoke(new Func<bool>(() => this.comboBoxParseSource.Enabled = set_value));
            this.Invoke(new Func<bool>(() => this.textBoxWordList.Enabled = set_value));
        }

        void DownloadThread()
        {
            int index = 0, EndCount = DownloadList.Count;

            SetControlEnable(false);

            string CrawlerTransSource = (string)this.Invoke(new Func<string>(() => this.comboBoxParseSource.Text));

            bDownloading = true;
            int ErrorCount = 0;
            while(DownloadList.Count>0 && bDownloading)
            {
                SetControlText(labelProgressBar, index + "/"+ EndCount);
                SetProgressBarValue(progressBarDownload, index);

                Translation.FuncOut< object, string> RunTrans = Translation.TransMappingTable[CrawlerTransSource];

                string TransOutput;
                if (!RunTrans(DownloadList[0], out TransOutput))
                {
                    string ErrorMessage = "Error Translate " + DownloadList[0];
                    EventLog.Write(ErrorMessage);
                    ErrorCount++;

                    if(Global.ErrorMessage == "IP Blocked")
                    {
                        MessageBox.Show("Your IP has been blocked, wait a moment to try download again!");
                        Global.ErrorMessage = "";
                        break;
                    }
                }
                else if (!oMemoOffObject.AddCardToDeck(DownloadList[0], TransOutput))
                {
                    string ErrorMessage = "Error Add " + DownloadList[0] + "Card To Deck";
                    EventLog.Write(ErrorMessage);
                    ErrorCount++;
                }

                DownloadList.RemoveAt(0);
                index++;
            }

            SetControlText(labelProgressBar, index + "/" + EndCount);
            SetProgressBarValue(progressBarDownload, index);
            bDownloading = false;
            UpdateTextBoxWordList();

            if(ErrorCount>0)
                MessageBox.Show("Error Translate or Add " + ErrorCount + " word... please refer EventLog.");

            SetControlEnable(true);
        }

        void UpdateTextBoxWordList()
        {
            StringBuilder temp = new StringBuilder();
            foreach(string s in DownloadList)
            {
                temp.Append(s+"\r\n");
            }
            SetControlText(textBoxWordList, temp.ToString());
        }

        void ParserSource()
        {
            DownloadList = new List<string>();
            string[] temp_a = textBoxWordList.Text.Split('\n');
            for(int i = 0; i < temp_a.Length; i++)
            {
                string temp_s = temp_a[i].Replace("\r","");
                if(temp_s!="")
                    DownloadList.Add(temp_s);
            }

            if (DownloadList.Count > 0)
            {
                progressBarDownload.Maximum = DownloadList.Count;

                DownloadingThread = new Thread(this.DownloadThread);
                DownloadingThread.IsBackground = true;
                DownloadingThread.Start();
            }
        }

        private void SetControlText(Control control,string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (control.InvokeRequired) //(threadXX -> this)
            {
                SetControlStringCallback d = new SetControlStringCallback(SetControlText);
                this.Invoke(d, new object[] { control, text });
            }
            else                        //this run
                control.Text = text;
        }

        private void SetProgressBarValue(ProgressBar pb, int value)
        {
            if (pb.InvokeRequired) //(threadXX -> this)
            {
                SetProgressBarIntCallback d = new SetProgressBarIntCallback(SetProgressBarValue);
                this.Invoke(d, new object[] { pb, value });
            }
            else                  //this run
                pb.Value = value;
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if(!bDownloading)
            {
                ParserSource();
            }
        }

        private void comboBoxDeck_SelectionChangeCommitted(object sender, EventArgs e)
        {
            oMemoOffObject.CurrentDeckIndex = comboBoxDeck.SelectedIndex;
            oMemoOffObject.ReadDeck();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            bDownloading = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
