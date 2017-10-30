namespace MemoOffVocabulary
{
    partial class WebCrawlerForm
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
            this.textBoxWordList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.comboBoxDeck = new System.Windows.Forms.ComboBox();
            this.comboBoxParseSource = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxWordList
            // 
            this.textBoxWordList.Location = new System.Drawing.Point(12, 72);
            this.textBoxWordList.MaxLength = 10000000;
            this.textBoxWordList.Multiline = true;
            this.textBoxWordList.Name = "textBoxWordList";
            this.textBoxWordList.Size = new System.Drawing.Size(389, 247);
            this.textBoxWordList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Deck, Source and Input New Card List:";
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(12, 331);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(291, 29);
            this.progressBarDownload.TabIndex = 3;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(12, 381);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(119, 30);
            this.buttonDownload.TabIndex = 4;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(148, 381);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(119, 30);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(282, 381);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(119, 30);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.AutoSize = true;
            this.labelProgressBar.Font = new System.Drawing.Font("新細明體", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelProgressBar.Location = new System.Drawing.Point(309, 336);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(29, 18);
            this.labelProgressBar.TabIndex = 7;
            this.labelProgressBar.Text = "0/0";
            // 
            // comboBoxDeck
            // 
            this.comboBoxDeck.DisplayMember = "0";
            this.comboBoxDeck.FormattingEnabled = true;
            this.comboBoxDeck.Location = new System.Drawing.Point(12, 42);
            this.comboBoxDeck.Name = "comboBoxDeck";
            this.comboBoxDeck.Size = new System.Drawing.Size(159, 24);
            this.comboBoxDeck.TabIndex = 8;
            this.comboBoxDeck.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDeck_SelectionChangeCommitted);
            // 
            // comboBoxParseSource
            // 
            this.comboBoxParseSource.DisplayMember = "0";
            this.comboBoxParseSource.FormattingEnabled = true;
            this.comboBoxParseSource.Location = new System.Drawing.Point(177, 42);
            this.comboBoxParseSource.Name = "comboBoxParseSource";
            this.comboBoxParseSource.Size = new System.Drawing.Size(224, 24);
            this.comboBoxParseSource.TabIndex = 2;
            // 
            // WebCrawlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 434);
            this.Controls.Add(this.comboBoxDeck);
            this.Controls.Add(this.labelProgressBar);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.comboBoxParseSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWordList);
            this.Name = "WebCrawlerForm";
            this.Text = "WebCrawlerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWordList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelProgressBar;
        private System.Windows.Forms.ComboBox comboBoxDeck;
        private System.Windows.Forms.ComboBox comboBoxParseSource;
    }
}