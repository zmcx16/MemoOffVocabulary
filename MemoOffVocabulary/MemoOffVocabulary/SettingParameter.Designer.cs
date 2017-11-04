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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingParameter));
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
            this.labelTTS = new System.Windows.Forms.Label();
            this.comboBoxDeckList = new System.Windows.Forms.ComboBox();
            this.comboBoxTTS_SpeechType = new System.Windows.Forms.ComboBox();
            this.trackBarSoundVolume = new System.Windows.Forms.TrackBar();
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
            this.groupBoxStudy.Location = new System.Drawing.Point(14, 13);
            this.groupBoxStudy.Name = "groupBoxStudy";
            this.groupBoxStudy.Size = new System.Drawing.Size(304, 192);
            this.groupBoxStudy.TabIndex = 0;
            this.groupBoxStudy.TabStop = false;
            this.groupBoxStudy.Text = "Study";
            this.groupBoxStudy.Enter += new System.EventHandler(this.groupBoxStudy_Enter);
            // 
            // labelEasy
            // 
            this.labelEasy.AutoSize = true;
            this.labelEasy.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEasy.Location = new System.Drawing.Point(7, 142);
            this.labelEasy.Name = "labelEasy";
            this.labelEasy.Size = new System.Drawing.Size(103, 19);
            this.labelEasy.TabIndex = 5;
            this.labelEasy.Text = "Easy (Days):";
            // 
            // labelAgain
            // 
            this.labelAgain.AutoSize = true;
            this.labelAgain.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAgain.Location = new System.Drawing.Point(7, 37);
            this.labelAgain.Name = "labelAgain";
            this.labelAgain.Size = new System.Drawing.Size(134, 19);
            this.labelAgain.TabIndex = 4;
            this.labelAgain.Text = "Again (Minutes):";
            // 
            // labelGood
            // 
            this.labelGood.AutoSize = true;
            this.labelGood.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelGood.Location = new System.Drawing.Point(7, 89);
            this.labelGood.Name = "labelGood";
            this.labelGood.Size = new System.Drawing.Size(115, 19);
            this.labelGood.TabIndex = 3;
            this.labelGood.Text = "Good (Hours):";
            // 
            // textBoxEasy
            // 
            this.textBoxEasy.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxEasy.Location = new System.Drawing.Point(194, 139);
            this.textBoxEasy.Name = "textBoxEasy";
            this.textBoxEasy.Size = new System.Drawing.Size(86, 30);
            this.textBoxEasy.TabIndex = 2;
            // 
            // textBoxGood
            // 
            this.textBoxGood.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxGood.Location = new System.Drawing.Point(194, 85);
            this.textBoxGood.Name = "textBoxGood";
            this.textBoxGood.Size = new System.Drawing.Size(86, 30);
            this.textBoxGood.TabIndex = 1;
            // 
            // textBoxAgain
            // 
            this.textBoxAgain.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxAgain.Location = new System.Drawing.Point(194, 34);
            this.textBoxAgain.Name = "textBoxAgain";
            this.textBoxAgain.Size = new System.Drawing.Size(86, 30);
            this.textBoxAgain.TabIndex = 0;
            // 
            // groupBoxOthers
            // 
            this.groupBoxOthers.Controls.Add(this.checkBoxEnableBringExeTop);
            this.groupBoxOthers.Controls.Add(this.checkBoxAutoStudy);
            this.groupBoxOthers.Controls.Add(this.textBoxAutoStudyInterval);
            this.groupBoxOthers.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxOthers.Location = new System.Drawing.Point(14, 453);
            this.groupBoxOthers.Name = "groupBoxOthers";
            this.groupBoxOthers.Size = new System.Drawing.Size(304, 137);
            this.groupBoxOthers.TabIndex = 6;
            this.groupBoxOthers.TabStop = false;
            this.groupBoxOthers.Text = "Others";
            this.groupBoxOthers.Enter += new System.EventHandler(this.groupBoxOthers_Enter);
            // 
            // checkBoxEnableBringExeTop
            // 
            this.checkBoxEnableBringExeTop.AutoSize = true;
            this.checkBoxEnableBringExeTop.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxEnableBringExeTop.Location = new System.Drawing.Point(10, 41);
            this.checkBoxEnableBringExeTop.Name = "checkBoxEnableBringExeTop";
            this.checkBoxEnableBringExeTop.Size = new System.Drawing.Size(254, 23);
            this.checkBoxEnableBringExeTop.TabIndex = 7;
            this.checkBoxEnableBringExeTop.Text = "Enable Memo Always On Top";
            this.checkBoxEnableBringExeTop.UseVisualStyleBackColor = true;
            this.checkBoxEnableBringExeTop.CheckedChanged += new System.EventHandler(this.checkBoxEnableBringExeTop_CheckedChanged);
            // 
            // checkBoxAutoStudy
            // 
            this.checkBoxAutoStudy.AutoSize = true;
            this.checkBoxAutoStudy.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxAutoStudy.Location = new System.Drawing.Point(10, 84);
            this.checkBoxAutoStudy.Name = "checkBoxAutoStudy";
            this.checkBoxAutoStudy.Size = new System.Drawing.Size(159, 23);
            this.checkBoxAutoStudy.TabIndex = 6;
            this.checkBoxAutoStudy.Text = "Auto Study (sec):";
            this.checkBoxAutoStudy.UseVisualStyleBackColor = true;
            // 
            // textBoxAutoStudyInterval
            // 
            this.textBoxAutoStudyInterval.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxAutoStudyInterval.Location = new System.Drawing.Point(194, 82);
            this.textBoxAutoStudyInterval.Name = "textBoxAutoStudyInterval";
            this.textBoxAutoStudyInterval.Size = new System.Drawing.Size(86, 30);
            this.textBoxAutoStudyInterval.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(11, 596);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 46);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(208, 596);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 46);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxTTS
            // 
            this.groupBoxTTS.Controls.Add(this.labelTTS);
            this.groupBoxTTS.Controls.Add(this.comboBoxDeckList);
            this.groupBoxTTS.Controls.Add(this.comboBoxTTS_SpeechType);
            this.groupBoxTTS.Controls.Add(this.trackBarSoundVolume);
            this.groupBoxTTS.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxTTS.Location = new System.Drawing.Point(14, 211);
            this.groupBoxTTS.Name = "groupBoxTTS";
            this.groupBoxTTS.Size = new System.Drawing.Size(304, 236);
            this.groupBoxTTS.TabIndex = 9;
            this.groupBoxTTS.TabStop = false;
            this.groupBoxTTS.Text = "Text-To-Speech(TTS)";
            // 
            // labelTTS
            // 
            this.labelTTS.AutoSize = true;
            this.labelTTS.Location = new System.Drawing.Point(8, 43);
            this.labelTTS.Name = "labelTTS";
            this.labelTTS.Size = new System.Drawing.Size(240, 20);
            this.labelTTS.TabIndex = 11;
            this.labelTTS.Text = "Enable Google Text-To-Speech";
            // 
            // comboBoxDeckList
            // 
            this.comboBoxDeckList.FormattingEnabled = true;
            this.comboBoxDeckList.Location = new System.Drawing.Point(10, 81);
            this.comboBoxDeckList.Name = "comboBoxDeckList";
            this.comboBoxDeckList.Size = new System.Drawing.Size(270, 27);
            this.comboBoxDeckList.TabIndex = 10;
            this.comboBoxDeckList.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeckList_SelectedIndexChanged);
            this.comboBoxDeckList.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDeckList_SelectionChangeCommitted);
            // 
            // comboBoxTTS_SpeechType
            // 
            this.comboBoxTTS_SpeechType.FormattingEnabled = true;
            this.comboBoxTTS_SpeechType.Location = new System.Drawing.Point(11, 133);
            this.comboBoxTTS_SpeechType.Name = "comboBoxTTS_SpeechType";
            this.comboBoxTTS_SpeechType.Size = new System.Drawing.Size(269, 27);
            this.comboBoxTTS_SpeechType.TabIndex = 9;
            this.comboBoxTTS_SpeechType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTTS_SpeechType_SelectedIndexChanged);
            this.comboBoxTTS_SpeechType.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTTS_SpeechType_SelectionChangeCommitted);
            // 
            // trackBarSoundVolume
            // 
            this.trackBarSoundVolume.Location = new System.Drawing.Point(7, 167);
            this.trackBarSoundVolume.Maximum = 100;
            this.trackBarSoundVolume.Name = "trackBarSoundVolume";
            this.trackBarSoundVolume.Size = new System.Drawing.Size(273, 61);
            this.trackBarSoundVolume.TabIndex = 8;
            this.trackBarSoundVolume.Value = 50;
            // 
            // SettingParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 660);
            this.Controls.Add(this.groupBoxTTS);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxOthers);
            this.Controls.Add(this.groupBoxStudy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingParameter";
            this.Load += new System.EventHandler(this.SettingParameter_Load);
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
        private System.Windows.Forms.ComboBox comboBoxDeckList;
        private System.Windows.Forms.Label labelTTS;
    }
}