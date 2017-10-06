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
    public partial class EditForm : Form
    {
        StringBuilder EditValue;
        public EditForm(StringBuilder EditValue, string ButtonOKText, string ButtonCancelText, string FormText)
        {
            InitializeComponent();
            buttonOK.Text = ButtonOKText;
            buttonCancel.Text = ButtonCancelText;
            this.Text = FormText;
            this.EditValue = EditValue;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            EditValue.Clear();
            EditValue.Append(EditText.Text);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
