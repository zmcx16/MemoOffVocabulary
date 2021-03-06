﻿namespace MemoOffVocabulary
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
            this.webCrawlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradChineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxDeck = new System.Windows.Forms.ComboBox();
            this.timer_study = new System.Windows.Forms.Timer(this.components);
            this.comboBoxParseSource = new System.Windows.Forms.ComboBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMemoOffVocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabControlForm.Location = new System.Drawing.Point(4, 40);
            this.tabControlForm.Name = "tabControlForm";
            this.tabControlForm.SelectedIndex = 0;
            this.tabControlForm.Size = new System.Drawing.Size(602, 199);
            this.tabControlForm.TabIndex = 0;
            this.tabControlForm.SelectedIndexChanged += new System.EventHandler(this.tabControlForm_SelectedIndexChanged);
            // 
            // tabPageStudy
            // 
            this.tabPageStudy.BackColor = System.Drawing.Color.LightSkyBlue;
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
            // 
            // buttonEasy
            // 
            this.buttonEasy.BackgroundImage = global::MemoOffVocabulary.Properties.Resources.button0;
            this.buttonEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEasy.FlatAppearance.BorderSize = 0;
            this.buttonEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEasy.Font = new System.Drawing.Font("新細明體", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonEasy.Location = new System.Drawing.Point(424, 121);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(153, 39);
            this.buttonEasy.TabIndex = 8;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            this.buttonEasy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonEasy_MouseDown);
            this.buttonEasy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonEasy_MouseUp);
            // 
            // buttonGood
            // 
            this.buttonGood.BackgroundImage = global::MemoOffVocabulary.Properties.Resources.button0;
            this.buttonGood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGood.FlatAppearance.BorderSize = 0;
            this.buttonGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGood.Font = new System.Drawing.Font("新細明體", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonGood.Location = new System.Drawing.Point(217, 121);
            this.buttonGood.Name = "buttonGood";
            this.buttonGood.Size = new System.Drawing.Size(153, 39);
            this.buttonGood.TabIndex = 7;
            this.buttonGood.Text = "Good";
            this.buttonGood.UseVisualStyleBackColor = true;
            this.buttonGood.Click += new System.EventHandler(this.buttonGood_Click);
            this.buttonGood.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonGood_MouseDown);
            this.buttonGood.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonGood_MouseUp);
            // 
            // buttonAgain
            // 
            this.buttonAgain.BackgroundImage = global::MemoOffVocabulary.Properties.Resources.button0;
            this.buttonAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAgain.FlatAppearance.BorderSize = 0;
            this.buttonAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgain.Font = new System.Drawing.Font("新細明體", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAgain.Location = new System.Drawing.Point(6, 121);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(153, 39);
            this.buttonAgain.TabIndex = 6;
            this.buttonAgain.Text = "Again";
            this.buttonAgain.UseVisualStyleBackColor = true;
            this.buttonAgain.Click += new System.EventHandler(this.buttonAgain_Click);
            this.buttonAgain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonAgain_MouseDown);
            this.buttonAgain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonAgain_MouseUp);
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
            this.tabPageAddCard.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPageAddCard.Controls.Add(this.textBoxValueword_a);
            this.tabPageAddCard.Controls.Add(this.textBoxKeyword_a);
            this.tabPageAddCard.Controls.Add(this.buttonClear);
            this.tabPageAddCard.Controls.Add(this.buttonAdd);
            this.tabPageAddCard.Location = new System.Drawing.Point(4, 26);
            this.tabPageAddCard.Name = "tabPageAddCard";
            this.tabPageAddCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddCard.Size = new System.Drawing.Size(594, 169);
            this.tabPageAddCard.TabIndex = 1;
            this.tabPageAddCard.Text = "Add Card";
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
            this.buttonClear.BackgroundImage = global::MemoOffVocabulary.Properties.Resources.button0;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("新細明體", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClear.Location = new System.Drawing.Point(427, 124);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(150, 39);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonClear_MouseDown);
            this.buttonClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonClear_MouseUp);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::MemoOffVocabulary.Properties.Resources.button0;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("新細明體", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAdd.Location = new System.Drawing.Point(220, 124);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 39);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonAdd_MouseDown);
            this.buttonAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonAdd_MouseUp);
            // 
            // menuStripForm
            // 
            this.menuStripForm.BackColor = System.Drawing.Color.Azure;
            this.menuStripForm.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStripForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripForm.Name = "menuStripForm";
            this.menuStripForm.Size = new System.Drawing.Size(616, 30);
            this.menuStripForm.TabIndex = 1;
            this.menuStripForm.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateDeckToolStripMenuItem,
            this.ManageDeckToolStripMenuItem,
            this.ParameterToolStripMenuItem,
            this.webCrawlerToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
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
            // webCrawlerToolStripMenuItem
            // 
            this.webCrawlerToolStripMenuItem.Name = "webCrawlerToolStripMenuItem";
            this.webCrawlerToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.webCrawlerToolStripMenuItem.Text = "Web Crawler";
            this.webCrawlerToolStripMenuItem.Click += new System.EventHandler(this.webCrawlerToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.tradChineseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // tradChineseToolStripMenuItem
            // 
            this.tradChineseToolStripMenuItem.Name = "tradChineseToolStripMenuItem";
            this.tradChineseToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.tradChineseToolStripMenuItem.Text = "繁體中文";
            this.tradChineseToolStripMenuItem.Click += new System.EventHandler(this.tradChineseToolStripMenuItem_Click);
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
            // comboBoxParseSource
            // 
            this.comboBoxParseSource.FormattingEnabled = true;
            this.comboBoxParseSource.Location = new System.Drawing.Point(192, 1);
            this.comboBoxParseSource.Name = "comboBoxParseSource";
            this.comboBoxParseSource.Size = new System.Drawing.Size(202, 24);
            this.comboBoxParseSource.TabIndex = 3;
            this.comboBoxParseSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxParseSource_SelectedIndexChanged);
            this.comboBoxParseSource.SelectionChangeCommitted += new System.EventHandler(this.comboBoxParseSource_SelectionChangeCommitted);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMemoOffVocabularyToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMemoOffVocabularyToolStripMenuItem
            // 
            this.aboutMemoOffVocabularyToolStripMenuItem.Name = "aboutMemoOffVocabularyToolStripMenuItem";
            this.aboutMemoOffVocabularyToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.aboutMemoOffVocabularyToolStripMenuItem.Text = "About MemoOffVocabulary";
            this.aboutMemoOffVocabularyToolStripMenuItem.Click += new System.EventHandler(this.aboutMemoOffVocabularyToolStripMenuItem_Click);
            // 
            // MemoOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(616, 245);
            this.Controls.Add(this.comboBoxParseSource);
            this.Controls.Add(this.comboBoxDeck);
            this.Controls.Add(this.tabControlForm);
            this.Controls.Add(this.menuStripForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripForm;
            this.Name = "MemoOffForm";
            this.Text = "MemoOffVocabulary by zmcx16";
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
        private System.Windows.Forms.ComboBox comboBoxParseSource;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradChineseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMemoOffVocabularyToolStripMenuItem;
    }
}

