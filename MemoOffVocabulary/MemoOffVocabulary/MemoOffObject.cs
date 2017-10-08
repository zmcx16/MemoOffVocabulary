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
        public List<string> lDeckList;
        public SortedDictionary<long, DeckStructure> CurrentDeck;
        public int CurrentDeckIndex;
        public string TTS_speechtype;

        public MemoOffObject()
        {
            lDeckList = new List<string>();
            CurrentDeck = new SortedDictionary<long, DeckStructure>();
            ReadDeckList();
            CurrentDeckIndex=0;
            ReadDeck();
        }

        public void ReadDeckList()
        {
            lDeckList = new List<string>();

            StringBuilder sDeckList = new StringBuilder();
            win32API.GetPrivateProfileString("Setting", "Deck_list", "",ref sDeckList, Global.Deck_path + "setting.ini");

            string[] temp = sDeckList.ToString().Split('\t');
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
                sDeckList.Append( s +"\t");
            }
            win32API.WritePrivateProfileString("Setting", "Deck_list", sDeckList.ToString(), Global.Deck_path + "setting.ini");
        }

        public void WriteDefaultDeckTTS_speechtype()
        {
            WriteDefaultDeckTTS_speechtype(CurrentDeckIndex);
        }

        public void WriteDefaultDeckTTS_speechtype(int SelectIndex)
        {
            win32API.WritePrivateProfileString(lDeckList[SelectIndex], "TTS_speechtype", Global.TTS_SpeechType_MappingTable[0].Key, Global.Deck_path + "setting.ini");
        }

        public bool GetCurrentDeckTTS_speechtype()
        {
            if (lDeckList.Count == 0)
                return false;
            
            StringBuilder temp = new StringBuilder();
            win32API.GetPrivateProfileString(lDeckList[CurrentDeckIndex], "TTS_speechtype", "", ref temp, Global.Deck_path + "setting.ini");
            TTS_speechtype = temp.ToString();

            return true;
        }

        public bool ReadDeck()
        {
            if (lDeckList.Count == 0)
                return false;

            string Deck = Global.Deck_path + lDeckList[CurrentDeckIndex] + ".json";
            if (File.Exists(Deck))
            {
                StringBuilder deck_file = new StringBuilder(File.ReadAllText(Deck));
                CurrentDeck = JsonConvert.DeserializeObject<SortedDictionary<long, DeckStructure>>(deck_file.ToString());
            }else
                CurrentDeck = new SortedDictionary<long, DeckStructure>();

            GetCurrentDeckTTS_speechtype();

            return true;
        }

        public bool ReadDeck(int selectDeckIndex)
        {
            CurrentDeckIndex = selectDeckIndex;
            return ReadDeck();
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

        public bool UpdateMemoDeck(int sec, int min, int hour, int day)
        {
            if (lDeckList.Count == 0)
                return false;

            long original_key = CurrentDeck.ElementAt(0).Key;

            DateTime dt = DateTime.ParseExact(original_key.ToString(), "yyyyMMddHHmmss", null);
            dt = dt.AddSeconds(sec); dt = dt.AddMinutes(min); dt = dt.AddHours(hour); dt = dt.AddDays(day);

            if (dt < DateTime.Now)
                dt = DateTime.Now;

            long new_key = HandleCollisionKey(long.Parse(dt.ToString("yyyyMMddHHmmss")));

            CurrentDeck.Add(new_key, new DeckStructure(CurrentDeck[original_key].keyword, CurrentDeck[original_key].valueword));
            CurrentDeck.Remove(original_key);

            return true;
        }

        public bool SaveDeck() 
        {
            if (lDeckList.Count > 0)
            {
                string DeckFile = Global.Deck_path + lDeckList[CurrentDeckIndex] + ".json";
                string output = JsonConvert.SerializeObject(CurrentDeck);
                File.WriteAllText(DeckFile, output);

                return true;
            }

            return false;
        }

        public bool AddCardToDeck(string keyword,string valueword)
        {
            if (lDeckList.Count == 0)
                return false;

            long new_key = HandleCollisionKey(long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss")));
            CurrentDeck.Add(new_key, new DeckStructure(keyword, valueword));            
            return SaveDeck();
        }
    }
}
