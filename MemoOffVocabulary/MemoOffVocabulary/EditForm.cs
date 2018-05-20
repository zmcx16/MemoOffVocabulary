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
        const float button_font_size = 9.969231F;
        const float button_font_press_size = 9.5F;

        StringBuilder EditValue;
        public EditForm(StringBuilder OutputEditValue, string InputEditText, string ButtonOKText, string ButtonCancelText, string FormText)
        {
            InitializeComponent();
            buttonOK.Text = ButtonOKText;
            buttonCancel.Text = ButtonCancelText;
            this.Text = FormText;
            this.EditText.Text = InputEditText;
            this.EditValue = OutputEditValue;

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

        private void SetbuttonState(Button button, float font_size, Bitmap button_img)
        {
            button.BackgroundImage = button_img;

            FontStyle fs = button.Font.Style;
            FontFamily ff = new FontFamily(buttonOK.Font.Name);
            Font f = new Font(ff, font_size, fs);
            button.Font = f;
        }

        private void buttonOK_MouseDown(object sender, MouseEventArgs e)
        {
            SetbuttonState(buttonOK, button_font_press_size, Properties.Resources.button0_1);
        }

        private void buttonOK_MouseUp(object sender, MouseEventArgs e)
        {
            SetbuttonState(buttonOK, button_font_size, Properties.Resources.button0);
        }

        private void buttonCancel_MouseDown(object sender, MouseEventArgs e)
        {
            SetbuttonState(buttonCancel, button_font_press_size, Properties.Resources.button0_1);
        }

        private void buttonCancel_MouseUp(object sender, MouseEventArgs e)
        {
            SetbuttonState(buttonCancel, button_font_size, Properties.Resources.button0);
        }
    }
}
