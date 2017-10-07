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
    public partial class ManageDeck : Form
    {
        MemoOffObject oMemoOffObject;
        List<KeyValuePair<string, long>> MappingTableValueToKey;

        public ManageDeck()
        {
            InitializeComponent();

            oMemoOffObject = new MemoOffObject();
            MappingTableValueToKey = new List<KeyValuePair<string, long>>();

            UpdatelistBoxDeckList();
        }

        private void UpdatelistBoxDeckList() 
        {
            listBoxDeckList.Items.Clear();
            foreach (string s in oMemoOffObject.lDeckList)
            {
                listBoxDeckList.Items.Add(s);
            }
        }

        private void UpdatelistBoxlistBoxKeyWord()
        {
            MappingTableValueToKey.Clear();
            listBoxKeyWord.Items.Clear();
            foreach (KeyValuePair<long, DeckStructure> o in oMemoOffObject.CurrentDeck)
            {
                MappingTableValueToKey.Add(new KeyValuePair<string, long>(o.Value.keyword, o.Key));  
            }
            MappingTableValueToKey.Sort((x, y) => x.Key.CompareTo(y.Key));
            foreach (KeyValuePair<string, long> o in MappingTableValueToKey)
            {
                listBoxKeyWord.Items.Add(o.Key);
            }
        }

        private void ManageDeck_Load(object sender, EventArgs e)
        {
           
        }

        private void listBoxDeckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxValueWord.Text = "";
            if (listBoxDeckList.SelectedIndex >= oMemoOffObject.lDeckList.Count || listBoxDeckList.SelectedIndex<0)
                return;

            oMemoOffObject.ReadDeck(listBoxDeckList.SelectedIndex);
            UpdatelistBoxlistBoxKeyWord();

        }

        private void listBoxKeyWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxKeyWord.SelectedIndex >= MappingTableValueToKey.Count || listBoxKeyWord.SelectedIndex < 0)
                return;

            textBoxValueWord.Text = oMemoOffObject.CurrentDeck[MappingTableValueToKey[listBoxKeyWord.SelectedIndex].Value].valueword;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            oMemoOffObject.CurrentDeck[MappingTableValueToKey[listBoxKeyWord.SelectedIndex].Value].valueword = textBoxValueWord.Text;
            oMemoOffObject.SaveDeck();
        }

        int FindSelectItemIndex(string find_key, ListBox lb)
        {
            for (int i=0;i<lb.Items.Count;i++) 
            {
                if (lb.Items[i].ToString() == find_key)
                    return i;
            }
            return -1;
        }

        private void AddStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            if (((ContextMenuStrip)tsmi.Owner).SourceControl.Name == listBoxDeckList.Name)
            {
                StringBuilder NewDeck = new StringBuilder();
                EditForm ef_d = new EditForm(NewDeck, "Create", "Cancel", "Create Deck");
                ef_d.ShowDialog();
                if (NewDeck.ToString() == "")
                    return;

                oMemoOffObject.lDeckList.Add(NewDeck.ToString());
                UpdatelistBoxDeckList();
                oMemoOffObject.SaveDeckList();

                listBoxDeckList.SelectedIndex = FindSelectItemIndex(NewDeck.ToString(), listBoxDeckList);
            }
            else if (((ContextMenuStrip)tsmi.Owner).SourceControl.Name == listBoxKeyWord.Name)
            {
                long new_key = oMemoOffObject.HandleCollisionKey(long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss")));
                StringBuilder NewCard = new StringBuilder();
                EditForm ef_c = new EditForm(NewCard, "Add", "Cancel", "Add Card");
                ef_c.ShowDialog();
                if (NewCard.ToString() == "")
                    return;

                oMemoOffObject.CurrentDeck.Add(new_key, new DeckStructure(NewCard.ToString(), ""));
                UpdatelistBoxlistBoxKeyWord();
                oMemoOffObject.SaveDeck();

                listBoxKeyWord.SelectedIndex = FindSelectItemIndex(NewCard.ToString(), listBoxKeyWord);
            }
        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            if (((ContextMenuStrip)tsmi.Owner).SourceControl.Name == listBoxDeckList.Name)
            {
                if (listBoxDeckList.SelectedIndex >= oMemoOffObject.lDeckList.Count || listBoxDeckList.SelectedIndex < 0)
                    return;
                StringBuilder RenameDeck = new StringBuilder();
                EditForm ef_d = new EditForm(RenameDeck, "Rename", "Cancel", "Rename Deck");
                ef_d.ShowDialog();
                if (RenameDeck.ToString() == "")
                    return;

                oMemoOffObject.lDeckList[listBoxDeckList.SelectedIndex] = RenameDeck.ToString();
                UpdatelistBoxDeckList();
                oMemoOffObject.SaveDeckList();

                listBoxDeckList.SelectedIndex = FindSelectItemIndex(RenameDeck.ToString(), listBoxDeckList);
            }
            else if (((ContextMenuStrip)tsmi.Owner).SourceControl.Name == listBoxKeyWord.Name)
            {
                if (listBoxKeyWord.SelectedIndex >= MappingTableValueToKey.Count || listBoxKeyWord.SelectedIndex < 0)
                    return;
                StringBuilder RenameCard = new StringBuilder();
                EditForm ef_c = new EditForm(RenameCard, "Rename", "Cancel", "Rename Card");
                ef_c.ShowDialog();
                if (RenameCard.ToString() == "")
                    return;

                oMemoOffObject.CurrentDeck[MappingTableValueToKey[listBoxKeyWord.SelectedIndex].Value].keyword = RenameCard.ToString();
                UpdatelistBoxlistBoxKeyWord();
                oMemoOffObject.SaveDeck();

                listBoxKeyWord.SelectedIndex = FindSelectItemIndex(RenameCard.ToString(), listBoxKeyWord);
            }

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            if (((ContextMenuStrip)tsmi.Owner).SourceControl.Name == listBoxDeckList.Name)
            {
                if (listBoxDeckList.SelectedItems.Count == 0)
                    return;

                DialogResult DialogDeleteDeck = MessageBox.Show("Are you sure you want to delete these decks?", "Warning!!", MessageBoxButtons.YesNo);
                if (DialogDeleteDeck == DialogResult.Yes)
                {
                    for (int i = listBoxDeckList.SelectedItems.Count - 1; i >= 0; i--)
                        oMemoOffObject.lDeckList.RemoveAt(listBoxDeckList.SelectedIndices[i]);

                    UpdatelistBoxDeckList();
                    oMemoOffObject.SaveDeckList();
                }
            }
            else if (((ContextMenuStrip)tsmi.Owner).SourceControl.Name == listBoxKeyWord.Name)
            {
                if (listBoxKeyWord.SelectedItems.Count == 0)
                    return;

                DialogResult DialogDeleteCard = MessageBox.Show("Are you sure you want to delete these cards?", "Warning!!", MessageBoxButtons.YesNo);
                if (DialogDeleteCard == DialogResult.Yes)
                {
                    for (int i = listBoxKeyWord.SelectedItems.Count - 1; i >= 0; i--)
                        oMemoOffObject.CurrentDeck.Remove(MappingTableValueToKey[listBoxKeyWord.SelectedIndices[i]].Value);

                    UpdatelistBoxlistBoxKeyWord();
                    oMemoOffObject.SaveDeck();
                }
            }

        }
    }
}
