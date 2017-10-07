namespace MemoOffVocabulary
{
    partial class SettingParameter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxStudy = new System.Windows.Forms.GroupBox();
            this.labelEasy = new System.Windows.Forms.Label();
            this.labelAgain = new System.Windows.Forms.Label();
            this.labelGood = new System.Windows.Forms.Label();
            this.textBoxEasy = new System.Windows.Forms.TextBox();
            this.textBoxGood = new System.Windows.Forms.TextBox();
            this.textBoxAgain = new System.Windows.Forms.TextBox();
            this.groupBoxOthers = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableBringExeTop = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoStudy = new System.Windows.Forms.CheckBox();
            this.textBoxAutoStudyInterval = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxTTS = new System.Windows.Forms.GroupBox();
            this.comboBoxTTS_SpeechType = new System.Windows.Forms.ComboBox();
            this.trackBarSoundVolume = new System.Windows.Forms.TrackBar();
            this.checkBoxEnableTTS = new System.Windows.Forms.CheckBox();
            this.groupBoxStudy.SuspendLayout();
            this.groupBoxOthers.SuspendLayout();
            this.groupBoxTTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSoundVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStudy
            // 
            this.groupBoxStudy.Controls.Add(this.labelEasy);
            this.groupBoxStudy.Controls.Add(this.labelAgain);
            this.groupBoxStudy.Controls.Add(this.labelGood);
            this.groupBoxStudy.Controls.Add(this.textBoxEasy);
            this.groupBoxStudy.Controls.Add(this.textBoxGood);
            this.groupBoxStudy.Controls.Add(this.textBoxAgain);
            this.groupBoxStudy.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxStudy.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStudy.Name = "groupBoxStudy";
            this.groupBoxStudy.Size = new System.Drawing.Size(262, 180);
            this.groupBoxStudy.TabIndex = 0;
            this.groupBoxStudy.TabStop = false;
            this.groupBoxStudy.Text = "Study";
            // 
            // labelEasy
            // 
            this.labelEasy.AutoSize = true;
            this.labelEasy.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEasy.Location = new System.Drawing.Point(6, 133);
            this.labelEasy.Name = "labelEasy";
            this.labelEasy.Size = new System.Drawing.Size(90, 17);
            this.labelEasy.TabIndex = 5;
            this.labelEasy.Text = "Easy (Days):";
            // 
            // labelAgain
            // 
            this.labelAgain.AutoSize = true;
            this.labelAgain.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAgain.Location = new System.Drawing.Point(6, 35);
            this.labelAgain.Name = "labelAgain";
            this.labelAgain.Size = new System.Drawing.Size(116, 17);
            this.labelAgain.TabIndex = 4;
            this.labelAgain.Text = "Again (Minutes):";
            // 
            // labelGood
            // 
            this.labelGood.AutoSize = true;
            this.labelGood.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelGood.Location = new System.Drawing.Point(6, 83);
            this.labelGood.Name = "labelGood";
            this.labelGood.Size = new System.Drawing.Size(101, 17);
            this.labelGood.TabIndex = 3;
            this.labelGood.Text = "Good (Hours):";
            // 
            // textBoxEasy
            // 
            this.textBoxEasy.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxEasy.Location = new System.Drawing.Point(172, 130);
            this.textBoxEasy.Name = "textBoxEasy";
            this.textBoxEasy.Size = new System.Drawing.Size(77, 28);
            this.textBoxEasy.TabIndex = 2;
            // 
            // textBoxGood
            // 
            this.textBoxGood.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxGood.Location = new System.Drawing.Point(172, 80);
            this.textBoxGood.Name = "textBoxGood";
            this.textBoxGood.Size = new System.Drawing.Size(77, 28);
            this.textBoxGood.TabIndex = 1;
            // 
            // textBoxAgain
            // 
            this.textBoxAgain.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxAgain.Location = new System.Drawing.Point(172, 32);
            this.textBoxAgain.Name = "textBoxAgain";
            this.textBoxAgain.Size = new System.Drawing.Size(77, 28);
            this.textBoxAgain.TabIndex = 0;
            // 
            // groupBoxOthers
            // 
            this.groupBoxOthers.Controls.Add(this.checkBoxEnableBringExeTop);
            this.groupBoxOthers.Controls.Add(this.checkBoxAutoStudy);
            this.groupBoxOthers.Controls.Add(this.textBoxAutoStudyInterval);
            this.groupBoxOthers.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxOthers.Location = new System.Drawing.Point(12, 390);
            this.groupBoxOthers.Name = "groupBoxOthers";
            this.groupBoxOthers.Size = new System.Drawing.Size(262, 128);
            this.groupBoxOthers.TabIndex = 6;
            this.groupBoxOthers.TabStop = false;
            this.groupBoxOthers.Text = "Others";
            // 
            // checkBoxEnableBringExeTop
            // 
            this.checkBoxEnableBringExeTop.AutoSize = true;
            this.checkBoxEnableBringExeTop.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxEnableBringExeTop.Location = new System.Drawing.Point(9, 38);
            this.checkBoxEnableBringExeTop.Name = "checkBoxEnableBringExeTop";
            this.checkBoxEnableBringExeTop.Size = new System.Drawing.Size(250, 21);
            this.checkBoxEnableBringExeTop.TabIndex = 7;
            this.checkBoxEnableBringExeTop.Text = "Enable Bring Exe Always On Top";
            this.checkBoxEnableBringExeTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoStudy
            // 
            this.checkBoxAutoStudy.AutoSize = true;
            this.checkBoxAutoStudy.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxAutoStudy.Location = new System.Drawing.Point(9, 79);
            this.checkBoxAutoStudy.Name = "checkBoxAutoStudy";
            this.checkBoxAutoStudy.Size = new System.Drawing.Size(141, 21);
            this.checkBoxAutoStudy.TabIndex = 6;
            this.checkBoxAutoStudy.Text = "Auto Study (sec):";
            this.checkBoxAutoStudy.UseVisualStyleBackColor = true;
            // 
            // textBoxAutoStudyInterval
            // 
            this.textBoxAutoStudyInterval.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxAutoStudyInterval.Location = new System.Drawing.Point(172, 77);
            this.textBoxAutoStudyInterval.Name = "textBoxAutoStudyInterval";
            this.textBoxAutoStudyInterval.Size = new System.Drawing.Size(77, 28);
            this.textBoxAutoStudyInterval.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 539);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 43);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(176, 539);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 43);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxTTS
            // 
            this.groupBoxTTS.Controls.Add(this.comboBoxTTS_SpeechType);
            this.groupBoxTTS.Controls.Add(this.trackBarSoundVolume);
            this.groupBoxTTS.Controls.Add(this.checkBoxEnableTTS);
            this.groupBoxTTS.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxTTS.Location = new System.Drawing.Point(12, 198);
            this.groupBoxTTS.Name = "groupBoxTTS";
            this.groupBoxTTS.Size = new System.Drawing.Size(262, 186);
            this.groupBoxTTS.TabIndex = 9;
            this.groupBoxTTS.TabStop = false;
            this.groupBoxTTS.Text = "Text-To-Speech(TTS)";
            // 
            // comboBoxTTS_SpeechType
            // 
            this.comboBoxTTS_SpeechType.FormattingEnabled = true;
            this.comboBoxTTS_SpeechType.Location = new System.Drawing.Point(9, 81);
            this.comboBoxTTS_SpeechType.Name = "comboBoxTTS_SpeechType";
            this.comboBoxTTS_SpeechType.Size = new System.Drawing.Size(231, 26);
            this.comboBoxTTS_SpeechType.TabIndex = 9;
            // 
            // trackBarSoundVolume
            // 
            this.trackBarSoundVolume.Location = new System.Drawing.Point(0, 124);
            this.trackBarSoundVolume.Maximum = 100;
            this.trackBarSoundVolume.Name = "trackBarSoundVolume";
            this.trackBarSoundVolume.Size = new System.Drawing.Size(240, 56);
            this.trackBarSoundVolume.TabIndex = 8;
            this.trackBarSoundVolume.Value = 50;
            // 
            // checkBoxEnableTTS
            // 
            this.checkBoxEnableTTS.AutoSize = true;
            this.checkBoxEnableTTS.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxEnableTTS.Location = new System.Drawing.Point(9, 38);
            this.checkBoxEnableTTS.Name = "checkBoxEnableTTS";
            this.checkBoxEnableTTS.Size = new System.Drawing.Size(232, 21);
            this.checkBoxEnableTTS.TabIndex = 5;
            this.checkBoxEnableTTS.Text = "Enable Google Text-To-Speech";
            this.checkBoxEnableTTS.UseVisualStyleBackColor = true;
            // 
            // SettingParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 594);
            this.Controls.Add(this.groupBoxTTS);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxOthers);
            this.Controls.Add(this.groupBoxStudy);
            this.Name = "SettingParameter";
            this.Text = "SettingParameter";
            this.groupBoxStudy.ResumeLayout(false);
            this.groupBoxStudy.PerformLayout();
            this.groupBoxOthers.ResumeLayout(false);
            this.groupBoxOthers.PerformLayout();
            this.groupBoxTTS.ResumeLayout(false);
            this.groupBoxTTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSoundVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStudy;
        private System.Windows.Forms.TextBox textBoxEasy;
        private System.Windows.Forms.TextBox textBoxGood;
        private System.Windows.Forms.TextBox textBoxAgain;
        private System.Windows.Forms.Label labelEasy;
        private System.Windows.Forms.Label labelAgain;
        private System.Windows.Forms.Label labelGood;
        private System.Windows.Forms.GroupBox groupBoxOthers;
        private System.Windows.Forms.TextBox textBoxAutoStudyInterval;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxAutoStudy;
        private System.Windows.Forms.CheckBox checkBoxEnableBringExeTop;
        private System.Windows.Forms.GroupBox groupBoxTTS;
        private System.Windows.Forms.ComboBox comboBoxTTS_SpeechType;
        private System.Windows.Forms.TrackBar trackBarSoundVolume;
        private System.Windows.Forms.CheckBox checkBoxEnableTTS;
    }
}