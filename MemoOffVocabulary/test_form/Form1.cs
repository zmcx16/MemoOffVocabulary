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
using System.Net;

namespace test_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                //this.Close();
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             WebClient webClient = new WebClient();

             webClient.CancelAsync();
             webClient.Dispose();
             while (webClient.IsBusy)
                 ;
             webClient.DownloadFileAsync(new Uri("http://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=Hello%20World&tl=en-us"), @"E:\00\01.mp3");
        */

            WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
            Player.PlayStateChange +=
                new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError +=
                new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            Player.URL = @"G:\work\MemoOffVocabulary\MemoOffVocabulary\MemoOffVocabulary\bin\Debug\Deck\Memo1\conceal.mp3";

            Player.settings.volume = int.Parse(textBox1.Text);

            textBox1.Text = Player.settings.volume.ToString();

            Player.controls.play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
