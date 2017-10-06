using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

using Newtonsoft.Json;
namespace MemoOffVocabulary
{
    public class MemoOffObject
    {
        public string sDeck_path = Directory.GetCurrentDirectory() + "\\Deck\\";
        public List<string> lDeckList;
        public SortedDictionary<long, DeckStructure> CurrentDeck;
        public string sCurrentDeckName;
        public int study_again=1,study_good=1,study_easy=1;

        public MemoOffObject()
        {
            lDeckList = new List<string>();
            CurrentDeck = new SortedDictionary<long, DeckStructure>();
            sCurrentDeckName = "";

            ReadDeckList();
            if (lDeckList.Count > 0)
                sCurrentDeckName = lDeckList[0];
            ReadDeck();
        }

        public void ReadDeckList()
        {
            lDeckList = new List<string>();

            StringBuilder sDeckList = new StringBuilder();
            win32API.GetPrivateProfileString("Setting", "Deck_list", "",ref sDeckList, sDeck_path + "setting.ini");

            string[] temp = sDeckList.ToString().Split(',');
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i]!="")
                    lDeckList.Add(temp[i]);
            }
        }

        public void SaveDeckList()
        {
            StringBuilder sDeckList = new StringBuilder();
            foreach(string s in lDeckList)
            {
                sDeckList.Append( s +",");
            }
            win32API.WritePrivateProfileString("Setting", "Deck_list", sDeckList.ToString(), sDeck_path + "setting.ini");
        }

        public void ReadDeck()
        {
            string Deck = sDeck_path + sCurrentDeckName + ".json";

            if (File.Exists(Deck))
            {
                StringBuilder deck_file = new StringBuilder(File.ReadAllText(Deck));
                CurrentDeck = JsonConvert.DeserializeObject<SortedDictionary<long, DeckStructure>>(deck_file.ToString());
            }else
                CurrentDeck = new SortedDictionary<long, DeckStructure>();
        }

        public void ReadDeck(int selectDeckIndex)
        {
            sCurrentDeckName = lDeckList[selectDeckIndex];
            ReadDeck();
        }

        public long HandleCollisionKey(long original_key)
        {
            long new_key = original_key;
            while (CurrentDeck.ContainsKey(new_key))
            {
                DateTime dt = DateTime.ParseExact(new_key.ToString(), "yyyyMMddHHmmss", null);
                dt = dt.AddSeconds(1);
                new_key = long.Parse(dt.ToString("yyyyMMddHHmmss"));
            }
            return new_key;
        }

        public void UpdateMemoDeck(int sec, int min, int hour, int day)
        {
            long original_key = CurrentDeck.ElementAt(0).Key;

            DateTime dt = DateTime.ParseExact(original_key.ToString(), "yyyyMMddHHmmss", null);
            dt = dt.AddSeconds(sec); dt = dt.AddMinutes(min); dt = dt.AddHours(hour); dt = dt.AddDays(day);

            if (dt < DateTime.Now)
                dt = DateTime.Now;

            long new_key = HandleCollisionKey(long.Parse(dt.ToString("yyyyMMddHHmmss")));

            CurrentDeck.Add(new_key, new DeckStructure(CurrentDeck[original_key].keyword, CurrentDeck[original_key].valueword));
            CurrentDeck.Remove(original_key);
        }

        public void SaveDeck() 
        {
            string DeckFile = sDeck_path + sCurrentDeckName + ".json";
            string output = JsonConvert.SerializeObject(CurrentDeck);
            File.WriteAllText(DeckFile, output);
        }

        public void AddCardToDeck(string keyword,string valueword)
        {
            long new_key = HandleCollisionKey(long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss")));
            CurrentDeck.Add(new_key, new DeckStructure(keyword, valueword));
            SaveDeck();
        }
    }
}
