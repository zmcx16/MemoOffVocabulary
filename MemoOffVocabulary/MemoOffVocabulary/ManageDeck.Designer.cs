
namespace MemoOffVocabulary
{
    partial class ManageDeck
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDeck));
            this.listBoxDeckList = new System.Windows.Forms.ListBox();
            this.contextMenuStripForListbox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxKeyWord = new System.Windows.Forms.ListBox();
            this.textBoxValueWord = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.contextMenuStripForListbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDeckList
            // 
            this.listBoxDeckList.ContextMenuStrip = this.contextMenuStripForListbox;
            this.listBoxDeckList.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxDeckList.FormattingEnabled = true;
            this.listBoxDeckList.HorizontalScrollbar = true;
            this.listBoxDeckList.ItemHeight = 18;
            this.listBoxDeckList.Location = new System.Drawing.Point(40, 42);
            this.listBoxDeckList.Name = "listBoxDeckList";
            this.listBoxDeckList.ScrollAlwaysVisible = true;
            this.listBoxDeckList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDeckList.Size = new System.Drawing.Size(198, 454);
            this.listBoxDeckList.TabIndex = 0;
            this.listBoxDeckList.SelectedIndexChanged += new System.EventHandler(this.listBoxDeckList_SelectedIndexChanged);
            this.listBoxDeckList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxDeckList_KeyUp);
            // 
            // contextMenuStripForListbox
            // 
            this.contextMenuStripForListbox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForListbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStripMenuItem,
            this.RenameToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.contextMenuStripForListbox.Name = "contextMenuStripForListbox";
            this.contextMenuStripForListbox.Size = new System.Drawing.Size(141, 76);
            // 
            // AddStripMenuItem
            // 
            this.AddStripMenuItem.Name = "AddStripMenuItem";
            this.AddStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.AddStripMenuItem.Text = "Setting";
            this.AddStripMenuItem.Click += new System.EventHandler(this.AddStripMenuItem_Click);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.RenameToolStripMenuItem.Text = "Rename";
            this.RenameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // listBoxKeyWord
            // 
            this.listBoxKeyWord.ContextMenuStrip = this.contextMenuStripForListbox;
            this.listBoxKeyWord.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxKeyWord.FormattingEnabled = true;
            this.listBoxKeyWord.HorizontalScrollbar = true;
            this.listBoxKeyWord.ItemHeight = 18;
            this.listBoxKeyWord.Location = new System.Drawing.Point(312, 42);
            this.listBoxKeyWord.Name = "listBoxKeyWord";
            this.listBoxKeyWord.ScrollAlwaysVisible = true;
            this.listBoxKeyWord.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxKeyWord.Size = new System.Drawing.Size(242, 454);
            this.listBoxKeyWord.TabIndex = 1;
            this.listBoxKeyWord.SelectedIndexChanged += new System.EventHandler(this.listBoxKeyWord_SelectedIndexChanged);
            this.listBoxKeyWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxKeyWord_KeyUp);
            // 
            // textBoxValueWord
            // 
            this.textBoxValueWord.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxValueWord.Location = new System.Drawing.Point(619, 42);
            this.textBoxValueWord.Multiline = true;
            this.textBoxValueWord.Name = "textBoxValueWord";
            this.textBoxValueWord.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxValueWord.Size = new System.Drawing.Size(417, 414);
            this.textBoxValueWord.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(619, 464);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 35);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(902, 464);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(134, 35);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ManageDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 545);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxValueWord);
            this.Controls.Add(this.listBoxKeyWord);
            this.Controls.Add(this.listBoxDeckList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageDeck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Deck";
            this.Load += new System.EventHandler(this.ManageDeck_Load);
            this.Resize += new System.EventHandler(this.ManageDeck_Resize);
            this.contextMenuStripForListbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDeckList;
        private System.Windows.Forms.ListBox listBoxKeyWord;
        private System.Windows.Forms.TextBox textBoxValueWord;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForListbox;
        private System.Windows.Forms.ToolStripMenuItem AddStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}