namespace MemoOffVocabulary
{
    partial class MemoOffForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoOffForm));
            this.tabControlForm = new System.Windows.Forms.TabControl();
            this.tabPageStudy = new System.Windows.Forms.TabPage();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonGood = new System.Windows.Forms.Button();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.textBoxValueword_s = new System.Windows.Forms.TextBox();
            this.textBoxKeyword_s = new System.Windows.Forms.TextBox();
            this.tabPageAddCard = new System.Windows.Forms.TabPage();
            this.textBoxValueword_a = new System.Windows.Forms.TextBox();
            this.textBoxKeyword_a = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStripForm = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxDeck = new System.Windows.Forms.ComboBox();
            this.timer_study = new System.Windows.Forms.Timer(this.components);
            this.webCrawlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlForm.SuspendLayout();
            this.tabPageStudy.SuspendLayout();
            this.tabPageAddCard.SuspendLayout();
            this.menuStripForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlForm
            // 
            this.tabControlForm.Controls.Add(this.tabPageStudy);
            this.tabControlForm.Controls.Add(this.tabPageAddCard);
            this.tabControlForm.Location = new System.Drawing.Point(8, 31);
            this.tabControlForm.Name = "tabControlForm";
            this.tabControlForm.SelectedIndex = 0;
            this.tabControlForm.Size = new System.Drawing.Size(602, 199);
            this.tabControlForm.TabIndex = 0;
            this.tabControlForm.SelectedIndexChanged += new System.EventHandler(this.tabControlForm_SelectedIndexChanged);
            // 
            // tabPageStudy
            // 
            this.tabPageStudy.Controls.Add(this.buttonEasy);
            this.tabPageStudy.Controls.Add(this.buttonGood);
            this.tabPageStudy.Controls.Add(this.buttonAgain);
            this.tabPageStudy.Controls.Add(this.textBoxValueword_s);
            this.tabPageStudy.Controls.Add(this.textBoxKeyword_s);
            this.tabPageStudy.Location = new System.Drawing.Point(4, 26);
            this.tabPageStudy.Name = "tabPageStudy";
            this.tabPageStudy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudy.Size = new System.Drawing.Size(594, 169);
            this.tabPageStudy.TabIndex = 0;
            this.tabPageStudy.Text = "Study";
            this.tabPageStudy.UseVisualStyleBackColor = true;
            // 
            // buttonEasy
            // 
            this.buttonEasy.Location = new System.Drawing.Point(424, 121);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(153, 39);
            this.buttonEasy.TabIndex = 8;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // buttonGood
            // 
            this.buttonGood.Location = new System.Drawing.Point(217, 121);
            this.buttonGood.Name = "buttonGood";
            this.buttonGood.Size = new System.Drawing.Size(153, 39);
            this.buttonGood.TabIndex = 7;
            this.buttonGood.Text = "Good";
            this.buttonGood.UseVisualStyleBackColor = true;
            this.buttonGood.Click += new System.EventHandler(this.buttonGood_Click);
            // 
            // buttonAgain
            // 
            this.buttonAgain.Location = new System.Drawing.Point(6, 121);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(153, 39);
            this.buttonAgain.TabIndex = 6;
            this.buttonAgain.Text = "Again";
            this.buttonAgain.UseVisualStyleBackColor = true;
            this.buttonAgain.Click += new System.EventHandler(this.buttonAgain_Click);
            // 
            // textBoxValueword_s
            // 
            this.textBoxValueword_s.Font = new System.Drawing.Font("新細明體", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxValueword_s.Location = new System.Drawing.Point(6, 46);
            this.textBoxValueword_s.Multiline = true;
            this.textBoxValueword_s.Name = "textBoxValueword_s";
            this.textBoxValueword_s.Size = new System.Drawing.Size(571, 69);
            this.textBoxValueword_s.TabIndex = 5;
            // 
            // textBoxKeyword_s
            // 
            this.textBoxKeyword_s.Font = new System.Drawing.Font("新細明體", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxKeyword_s.Location = new System.Drawing.Point(6, 6);
            this.textBoxKeyword_s.Name = "textBoxKeyword_s";
            this.textBoxKeyword_s.Size = new System.Drawing.Size(571, 34);
            this.textBoxKeyword_s.TabIndex = 4;
            // 
            // tabPageAddCard
            // 
            this.tabPageAddCard.Controls.Add(this.textBoxValueword_a);
            this.tabPageAddCard.Controls.Add(this.textBoxKeyword_a);
            this.tabPageAddCard.Controls.Add(this.buttonClear);
            this.tabPageAddCard.Controls.Add(this.buttonAdd);
            this.tabPageAddCard.Location = new System.Drawing.Point(4, 26);
            this.tabPageAddCard.Name = "tabPageAddCard";
            this.tabPageAddCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddCard.Size = new System.Drawing.Size(594, 169);
            this.tabPageAddCard.TabIndex = 1;
            this.tabPageAddCard.Text = "AddCard";
            this.tabPageAddCard.UseVisualStyleBackColor = true;
            this.tabPageAddCard.Click += new System.EventHandler(this.tabPageAddCard_Click);
            // 
            // textBoxValueword_a
            // 
            this.textBoxValueword_a.Font = new System.Drawing.Font("新細明體", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxValueword_a.Location = new System.Drawing.Point(6, 46);
            this.textBoxValueword_a.Multiline = true;
            this.textBoxValueword_a.Name = "textBoxValueword_a";
            this.textBoxValueword_a.Size = new System.Drawing.Size(571, 69);
            this.textBoxValueword_a.TabIndex = 3;
            // 
            // textBoxKeyword_a
            // 
            this.textBoxKeyword_a.Font = new System.Drawing.Font("新細明體", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxKeyword_a.Location = new System.Drawing.Point(6, 6);
            this.textBoxKeyword_a.Name = "textBoxKeyword_a";
            this.textBoxKeyword_a.Size = new System.Drawing.Size(571, 34);
            this.textBoxKeyword_a.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(323, 121);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(255, 39);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 121);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(255, 39);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // menuStripForm
            // 
            this.menuStripForm.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStripForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.menuStripForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripForm.Name = "menuStripForm";
            this.menuStripForm.Size = new System.Drawing.Size(616, 28);
            this.menuStripForm.TabIndex = 1;
            this.menuStripForm.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateDeckToolStripMenuItem,
            this.ManageDeckToolStripMenuItem,
            this.ParameterToolStripMenuItem,
            this.webCrawlerToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // CreateDeckToolStripMenuItem
            // 
            this.CreateDeckToolStripMenuItem.Name = "CreateDeckToolStripMenuItem";
            this.CreateDeckToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.CreateDeckToolStripMenuItem.Text = "Create Deck";
            this.CreateDeckToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemCreateDeck_Click);
            // 
            // ManageDeckToolStripMenuItem
            // 
            this.ManageDeckToolStripMenuItem.Name = "ManageDeckToolStripMenuItem";
            this.ManageDeckToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.ManageDeckToolStripMenuItem.Text = "Manage Deck";
            this.ManageDeckToolStripMenuItem.Click += new System.EventHandler(this.ManageDeckToolStripMenuItem_Click);
            // 
            // ParameterToolStripMenuItem
            // 
            this.ParameterToolStripMenuItem.Name = "ParameterToolStripMenuItem";
            this.ParameterToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.ParameterToolStripMenuItem.Text = "Parameter";
            this.ParameterToolStripMenuItem.Click += new System.EventHandler(this.ParameterToolStripMenuItem_Click);
            // 
            // comboBoxDeck
            // 
            this.comboBoxDeck.FormattingEnabled = true;
            this.comboBoxDeck.Location = new System.Drawing.Point(413, 1);
            this.comboBoxDeck.Name = "comboBoxDeck";
            this.comboBoxDeck.Size = new System.Drawing.Size(177, 24);
            this.comboBoxDeck.TabIndex = 2;
            this.comboBoxDeck.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDeck_SelectionChangeCommitted);
            // 
            // timer_study
            // 
            this.timer_study.Interval = 10000;
            this.timer_study.Tick += new System.EventHandler(this.timer_study_Tick);
            // 
            // webCrawlerToolStripMenuItem
            // 
            this.webCrawlerToolStripMenuItem.Name = "webCrawlerToolStripMenuItem";
            this.webCrawlerToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.webCrawlerToolStripMenuItem.Text = "Web Crawler";
            this.webCrawlerToolStripMenuItem.Click += new System.EventHandler(this.webCrawlerToolStripMenuItem_Click);
            // 
            // MemoOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 235);
            this.Controls.Add(this.comboBoxDeck);
            this.Controls.Add(this.tabControlForm);
            this.Controls.Add(this.menuStripForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripForm;
            this.Name = "MemoOffForm";
            this.Text = "MemoOffVocabulary Ver1.0 by zmcx16";
            this.Activated += new System.EventHandler(this.MemoOffForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemoOffForm_FormClosing);
            this.Load += new System.EventHandler(this.MemoOffForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MemoOffForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MemoOffForm_Resize);
            this.tabControlForm.ResumeLayout(false);
            this.tabPageStudy.ResumeLayout(false);
            this.tabPageStudy.PerformLayout();
            this.tabPageAddCard.ResumeLayout(false);
            this.tabPageAddCard.PerformLayout();
            this.menuStripForm.ResumeLayout(false);
            this.menuStripForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlForm;
        private System.Windows.Forms.TabPage tabPageStudy;
        private System.Windows.Forms.TabPage tabPageAddCard;
        private System.Windows.Forms.TextBox textBoxValueword_a;
        private System.Windows.Forms.TextBox textBoxKeyword_a;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxValueword_s;
        private System.Windows.Forms.TextBox textBoxKeyword_s;
        private System.Windows.Forms.MenuStrip menuStripForm;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateDeckToolStripMenuItem;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonGood;
        private System.Windows.Forms.Button buttonAgain;
        private System.Windows.Forms.Timer timer_study;
        private System.Windows.Forms.ToolStripMenuItem ManageDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webCrawlerToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxDeck;
    }
}

