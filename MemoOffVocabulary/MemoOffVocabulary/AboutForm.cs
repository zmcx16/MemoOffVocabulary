using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoOffVocabulary
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            
            labelMemoOffVocabularyVersionVal.Text = typeof(MemoOffForm).Assembly.GetName().Version.Major.ToString() + "." + typeof(MemoOffForm).Assembly.GetName().Version.Minor.ToString();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelHomePage.LinkVisited = true;
            System.Diagnostics.Process.Start("http://zmcx16.blogspot.tw/");
        }
    }
}
