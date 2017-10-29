using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MemoOffVocabulary
{
    public partial class ManageDeck : Form
    {
        MemoOffObject oMemoOffObject;
        List<KeyValuePair<string, long>> MappingTableValueToKey;
        bool IsInitial_completed = false;

        Point OrgThisSize,
        DifflistBoxDeckListSize, DifflistBoxKeyWordSize, DifftextBoxValueWordSize,
        DiffbuttonSaveLocation, DiffbuttonBackLocation;

        public ManageDeck()
        {
            InitializeComponent();
            SaveControlsLocationSize();

            oMemoOffObject = new MemoOffObject();
            MappingTableValueToKey = new List<KeyValuePair<string, long>>();

            UpdatelistBoxDeckList();

            IsInitial_completed = true;
        }

        public void SaveControlsLocationSize()
        {
            OrgThisSize = new Point(this.Width, this.Height);

            DifflistBoxDeckListSize = new Point(this.Width - listBoxDeckList.Width, this.Height - listBoxDeckList.Height);
            DifflistBoxKeyWordSize = new Point(this.Width - listBoxKeyWord.Width, this.Height - listBoxKeyWord.Height);
            DifftextBoxValueWordSize = new Point(this.Width - textBoxValueWord.Width, this.Height - textBoxValueWord.Height);

            DiffbuttonSaveLocation = new Point(this.Width - buttonSave.Location.X, this.Height - buttonSave.Location.Y);
            DiffbuttonBackLocation = new Point(this.Width - buttonBack.Location.X, this.Height - buttonBack.Location.Y);
        }

        private void ManageDeck_Resize(object sender, EventArgs e)
        {
            if (IsInitial_completed)
            {
                if (this.Width >= OrgThisSize.X)
                {
                    listBoxDeckList.Height = this.Height - DifflistBoxDeckListSize.Y;
                    listBoxKeyWord.Height = this.Height - DifflistBoxKeyWordSize.Y;
                    textBoxValueWord.Width = this.Width - DifftextBoxValueWordSize.X; textBoxValueWord.Height = this.Height - DifftextBoxValueWordSize.Y;

                    buttonSave.Location = new Point(this.Width - DiffbuttonSaveLocation.X, this.Height - DiffbuttonSaveLocation.Y);
                    buttonBack.Location = new Point(this.Width - DiffbuttonBackLocation.X, this.Height - DiffbuttonBackLocation.Y);
                }
                else if (this.Width < OrgThisSize.X || this.Height < OrgThisSize.Y)
                {
                    this.Width = OrgThisSize.X;
                    this.Height = OrgThisSize.Y;
                }
            }
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
            if (listBoxKeyWord.SelectedIndex != -1)
            {
                oMemoOffObject.CurrentDeck[MappingTableValueToKey[listBoxKeyWord.SelectedIndex].Value].valueword = textBoxValueWord.Text;
                oMemoOffObject.SaveDeck();
            }
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
                EditForm ef_d = new EditForm(NewDeck,"", "Create", "Cancel", "Create Deck");
                ef_d.ShowDialog();
                if (NewDeck.ToString() == "")
                    return;
                else if (oMemoOffObject.lDeckList.Contains(NewDeck.ToString()))
                {
                    string ErrorMessage = "Duplicate deck, try another deck name!!";
                    EventLog.Write(ErrorMessage);
                    MessageBox.Show(ErrorMessage);
                    return;
                }

                oMemoOffObject.lDeckList.Add(NewDeck.ToString());
                oMemoOffObject.WriteDefaultDeckTTS_speechtype(oMemoOffObject.lDeckList.Count - 1);
                UpdatelistBoxDeckList();
                oMemoOffObject.SaveDeckList();

                listBoxDeckList.SelectedIndex = FindSelectItemIndex(NewDeck.ToString(), listBoxDeckList);
            }
            else if (((ContextMenuStrip)tsmi.Owner).SourceControl.Name == listBoxKeyWord.Name && listBoxDeckList.SelectedIndex != -1)
            {
                long new_key = oMemoOffObject.HandleCollisionKey(long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss")));
                StringBuilder NewCard = new StringBuilder();
                EditForm ef_c = new EditForm(NewCard,"", "Add", "Cancel", "Add Card");
                ef_c.ShowDialog();
                if (NewCard.ToString() == "")
                    return;

                oMemoOffObject.CurrentDeck.Add(new_key, new DeckStructure(NewCard.ToString(), ""));
                UpdatelistBoxlistBoxKeyWord();
                oMemoOffObject.SaveDeck();

                string CardFile_Path = Global.Deck_path + oMemoOffObject.lDeckList[listBoxDeckList.SelectedIndex] + "\\" + NewCard.ToString() + "_" + oMemoOffObject.TTS_speechtype + ".mp3";
                TTS.DownloadTTSThread(NewCard.ToString(), CardFile_Path, oMemoOffObject.TTS_speechtype);

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
                StringBuilder sRenameDeck = new StringBuilder();
                EditForm ef_d = new EditForm(sRenameDeck, oMemoOffObject.lDeckList[listBoxDeckList.SelectedIndex], "Rename", "Cancel", "Rename Deck");
                ef_d.ShowDialog();
                if (sRenameDeck.ToString() == "")
                    return;
                else if (File.Exists(Global.Deck_path + sRenameDeck.ToString() + ".json") || Directory.Exists(Global.Deck_path + sRenameDeck.ToString()))
                {
                    string ErrorMessage = "Duplicate directory or File, try another deck name!!";
                    EventLog.Write(ErrorMessage);
                    MessageBox.Show(ErrorMessage);
                    return;
                }

                win32API.WritePrivateProfileString(oMemoOffObject.lDeckList[listBoxDeckList.SelectedIndex], null,null, Global.Deck_path + "setting.ini");
                win32API.WritePrivateProfileString(sRenameDeck.ToString(), "TTS_speechtype", Global.TTS_SpeechType_MappingTable[0].Key, Global.Deck_path + "setting.ini");
                RenameDeck(oMemoOffObject.lDeckList[listBoxDeckList.SelectedIndex], sRenameDeck.ToString());
                oMemoOffObject.lDeckList[listBoxDeckList.SelectedIndex] = sRenameDeck.ToString();
                UpdatelistBoxDeckList();
                oMemoOffObject.SaveDeckList();

                listBoxDeckList.SelectedIndex = FindSelectItemIndex(sRenameDeck.ToString(), listBoxDeckList);
            }
            else if (((ContextMenuStrip)tsmi.Owner).SourceControl.Name == listBoxKeyWord.Name && listBoxDeckList.SelectedIndex != -1)
            {
                if (listBoxKeyWord.SelectedIndex >= MappingTableValueToKey.Count || listBoxKeyWord.SelectedIndex < 0)
                    return;
                StringBuilder RenameCard = new StringBuilder();
                EditForm ef_c = new EditForm(RenameCard, oMemoOffObject.CurrentDeck[MappingTableValueToKey[listBoxKeyWord.SelectedIndex].Value].keyword, "Rename", "Cancel", "Rename Card");
                ef_c.ShowDialog();
                if (RenameCard.ToString() == "")
                    return;

                oMemoOffObject.CurrentDeck[MappingTableValueToKey[listBoxKeyWord.SelectedIndex].Value].keyword = RenameCard.ToString();
                UpdatelistBoxlistBoxKeyWord();
                oMemoOffObject.SaveDeck();

                listBoxKeyWord.SelectedIndex = FindSelectItemIndex(RenameCard.ToString(), listBoxKeyWord);
            }

        }

        private void DeleteDeckOrCard(string FocusControlName)
        {
            if (FocusControlName == listBoxDeckList.Name)
            {
                if (listBoxDeckList.SelectedItems.Count == 0)
                    return;

                DialogResult DialogDeleteDeck = MessageBox.Show("Are you sure you want to delete these decks?", "Warning!!", MessageBoxButtons.YesNo);
                if (DialogDeleteDeck == DialogResult.Yes)
                {
                    for (int i = listBoxDeckList.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        DeleteDeck(listBoxDeckList.SelectedItems[i].ToString());
                        oMemoOffObject.lDeckList.RemoveAt(listBoxDeckList.SelectedIndices[i]);
                    }
                    listBoxKeyWord.Items.Clear();

                    UpdatelistBoxDeckList();
                    oMemoOffObject.SaveDeckList();
                }
            }
            else if (FocusControlName == listBoxKeyWord.Name && listBoxDeckList.SelectedIndex!=-1)
            {
                if (listBoxKeyWord.SelectedItems.Count == 0)
                    return;

                DialogResult DialogDeleteCard = MessageBox.Show("Are you sure you want to delete these cards?", "Warning!!", MessageBoxButtons.YesNo);
                if (DialogDeleteCard == DialogResult.Yes)
                {
                    for (int i = listBoxKeyWord.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        DeleteCard(listBoxDeckList.SelectedItem.ToString(), MappingTableValueToKey[listBoxKeyWord.SelectedIndices[i]].Key, oMemoOffObject.TTS_speechtype);
                        oMemoOffObject.CurrentDeck.Remove(MappingTableValueToKey[listBoxKeyWord.SelectedIndices[i]].Value);
                    }

                    UpdatelistBoxlistBoxKeyWord();
                    oMemoOffObject.SaveDeck();
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FocusControlName = "";
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            if (((ContextMenuStrip)tsmi.Owner).SourceControl.Name == listBoxDeckList.Name)
                FocusControlName = listBoxDeckList.Name;
            else if (((ContextMenuStrip)tsmi.Owner).SourceControl.Name == listBoxKeyWord.Name)
                FocusControlName = listBoxKeyWord.Name;

            DeleteDeckOrCard(FocusControlName);
        }

        private void listBoxDeckList_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    DeleteDeckOrCard(listBoxDeckList.Name);
                    break;

                default:
                    break;
            }
        }

        public void RenameDeck(string OrgDeckName, string DestDeckName)
        {
            string OrgDeckFile = Global.Deck_path + OrgDeckName + ".json";
            string DestDeckFile = Global.Deck_path + DestDeckName + ".json";
            File.Move(OrgDeckFile, DestDeckFile);
            if (!File.Exists(DestDeckFile))
                File.Move(OrgDeckFile, DestDeckFile);

            string OrgDeckDir = Global.Deck_path + OrgDeckName;
            string DestDeckDir = Global.Deck_path + DestDeckName;
            if (!Directory.Exists(DestDeckDir))
                Directory.Move(OrgDeckDir, DestDeckDir);
        }

        public void DeleteDeck(string DeckName)
        {
            string DeckFile = Global.Deck_path + DeckName + ".json";
            if (File.Exists(DeckFile))
                File.Delete(DeckFile);

            string DeckDir = Global.Deck_path + DeckName;
            if (Directory.Exists(DeckDir))
                Directory.Delete(DeckDir,true);
        }

        public void DeleteCard(string DeckName, string CardName, string TTS_speechtype)
        {
            string CardSoundFile = Global.Deck_path + DeckName + "\\" + CardName + "_" + TTS_speechtype + ".mp3";
            if (File.Exists(CardSoundFile))
                File.Delete(CardSoundFile);
        }

        private void listBoxKeyWord_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    DeleteDeckOrCard(listBoxKeyWord.Name);
                    break;

                default:
                    break;
            }
        }

    }
}
