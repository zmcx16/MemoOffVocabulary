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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStudy = new System.Windows.Forms.TabPage();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonGood = new System.Windows.Forms.Button();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.textBoxValueword_s = new System.Windows.Forms.TextBox();
            this.textBoxKeyword_s = new System.Windows.Forms.TextBox();
            this.tabPageAddWord = new System.Windows.Forms.TabPage();
            this.textBoxValueword_a = new System.Windows.Forms.TextBox();
            this.textBoxKeyword_a = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.timer_BringExeTop = new System.Windows.Forms.Timer(this.components);
            this.timer_study = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageStudy.SuspendLayout();
            this.tabPageAddWord.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStudy);
            this.tabControl1.Controls.Add(this.tabPageAddWord);
            this.tabControl1.Location = new System.Drawing.Point(8, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 199);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
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
            this.tabPageStudy.Size = new System.Drawing.Size(594, 163);
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
            // 
            // buttonGood
            // 
            this.buttonGood.Location = new System.Drawing.Point(217, 121);
            this.buttonGood.Name = "buttonGood";
            this.buttonGood.Size = new System.Drawing.Size(153, 39);
            this.buttonGood.TabIndex = 7;
            this.buttonGood.Text = "Good";
            this.buttonGood.UseVisualStyleBackColor = true;
            // 
            // buttonAgain
            // 
            this.buttonAgain.Location = new System.Drawing.Point(6, 121);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(153, 39);
            this.buttonAgain.TabIndex = 6;
            this.buttonAgain.Text = "Again";
            this.buttonAgain.UseVisualStyleBackColor = true;
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
            // tabPageAddWord
            // 
            this.tabPageAddWord.Controls.Add(this.textBoxValueword_a);
            this.tabPageAddWord.Controls.Add(this.textBoxKeyword_a);
            this.tabPageAddWord.Controls.Add(this.buttonClear);
            this.tabPageAddWord.Controls.Add(this.buttonAdd);
            this.tabPageAddWord.Location = new System.Drawing.Point(4, 26);
            this.tabPageAddWord.Name = "tabPageAddWord";
            this.tabPageAddWord.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddWord.Size = new System.Drawing.Size(594, 169);
            this.tabPageAddWord.TabIndex = 1;
            this.tabPageAddWord.Text = "AddWord";
            this.tabPageAddWord.UseVisualStyleBackColor = true;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(165, 28);
            this.groupToolStripMenuItem.Text = "Parameter";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(413, 1);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(177, 24);
            this.comboBoxGroup.TabIndex = 2;
            // 
            // timer_BringExeTop
            // 
            this.timer_BringExeTop.Interval = 1000;
            this.timer_BringExeTop.Tick += new System.EventHandler(this.timer_BringExeTop_Tick);
            // 
            // timer_study
            // 
            this.timer_study.Interval = 10000;
            this.timer_study.Tick += new System.EventHandler(this.timer_study_Tick);
            // 
            // MemoOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 235);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MemoOffForm";
            this.Text = "MemoOffVocabulary by zmcx16";
            this.Load += new System.EventHandler(this.MemoOffForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageStudy.ResumeLayout(false);
            this.tabPageStudy.PerformLayout();
            this.tabPageAddWord.ResumeLayout(false);
            this.tabPageAddWord.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStudy;
        private System.Windows.Forms.TabPage tabPageAddWord;
        private System.Windows.Forms.TextBox textBoxValueword_a;
        private System.Windows.Forms.TextBox textBoxKeyword_a;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxValueword_s;
        private System.Windows.Forms.TextBox textBoxKeyword_s;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonGood;
        private System.Windows.Forms.Button buttonAgain;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Timer timer_BringExeTop;
        private System.Windows.Forms.Timer timer_study;
    }
}

