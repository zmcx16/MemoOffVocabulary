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

        delegate void SetControlStringCallback(Control ControlObject, string SetValue);
        delegate void SetProgressBarIntCallback(ProgressBar pb, int SetValue);

        public WebCrawlerForm()
        {
            InitializeComponent();

            oMemoOffObject = new MemoOffObject();
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

        void DownloadThread(object o)
        {
            string CrawlerTransSource = (string)this.Invoke(new Func<string>(() => this.comboBoxParseSource.Text));

            bDownloading = true;
            List<string> wordlist = (List<string>)o;
            for (int i=0;i<wordlist.Count;i++)
            {
                SetControlText(labelProgressBar, i+"/"+ wordlist.Count);
                SetProgressBarValue(progressBarDownload,i);

                Translation.FuncOut< object, string> RunTrans = Translation.TransMappingTable[CrawlerTransSource];

                string TransOutput;
                if (!RunTrans(wordlist[i],out TransOutput))
                    MessageBox.Show("Error Translate " + wordlist[i]);

            }

            SetControlText(labelProgressBar, wordlist.Count + "/" + wordlist.Count);
            SetProgressBarValue(progressBarDownload, wordlist.Count);
            bDownloading = false;
        }

        void ParserSource()
        {
            List<string> wordlist = new List<string>();
            string[] temp_a = textBoxWordList.Text.Split('\n');
            for(int i = 0; i < temp_a.Length; i++)
            {
                string temp_s = temp_a[i].Replace("\r","");
                if(temp_s!="")
                    wordlist.Add(temp_s);
            }
            progressBarDownload.Maximum = wordlist.Count;
            
            Thread t = new Thread(this.DownloadThread);
            t.IsBackground = true;
            t.Start(wordlist);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WebCrawlerForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxParseSource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
