using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace MemoOffVocabulary
{
    class Global
    {
        public static string ErrorMessage = ""; 

        public static KeyValuePair<string, string>[] TTS_SpeechType_MappingTable
               = { new KeyValuePair<string, string>("None", "None"),
                   new KeyValuePair<string, string>("EN_us", "English (United States)"), new KeyValuePair<string, string>("EN_uk", "English (United Kingdom)"), 
                   new KeyValuePair<string, string>("ja", "Japanese"),new KeyValuePair<string, string>("zh_TW", "Traditional Chinese")};

        public static string Deck_path = Directory.GetCurrentDirectory() + "\\Deck\\";
        public static int StudyAgainInterval = 1, StudyGoodInterval = 1, StudyEasyInterval = 1;
        public static int AutoStudyInterval = 10;
        public static bool EnableBringExeTop = true;
        public static bool EnableAutoStudy = true;
        public static int SoundVolume = 50;

        public static void WriteSettingToIni()
        {
            win32API.WritePrivateProfileString("Setting", "StudyAgainInterval", Global.StudyAgainInterval.ToString(), Global.Deck_path + "setting.ini");
            win32API.WritePrivateProfileString("Setting", "StudyGoodInterval", Global.StudyGoodInterval.ToString(), Global.Deck_path + "setting.ini");
            win32API.WritePrivateProfileString("Setting", "StudyEasyInterval", Global.StudyEasyInterval.ToString(), Global.Deck_path + "setting.ini");
            win32API.WritePrivateProfileString("Setting", "AutoStudyInterval", Global.AutoStudyInterval.ToString(), Global.Deck_path + "setting.ini");
            win32API.WritePrivateProfileString("Setting", "EnableBringExeTop", Global.EnableBringExeTop.ToString(), Global.Deck_path + "setting.ini");
            win32API.WritePrivateProfileString("Setting", "EnableAutoStudy", Global.EnableAutoStudy.ToString(), Global.Deck_path + "setting.ini");
            win32API.WritePrivateProfileString("Setting", "SoundVolume", Global.SoundVolume.ToString(), Global.Deck_path + "setting.ini");
        }

        public static void ReadSettingToIni()
        {
            try
            {
                StringBuilder temp = new StringBuilder();
                win32API.GetPrivateProfileString("Setting", "StudyAgainInterval", StudyAgainInterval.ToString(), ref temp, Global.Deck_path + "setting.ini");
                StudyAgainInterval = int.Parse(temp.ToString());
                win32API.GetPrivateProfileString("Setting", "StudyGoodInterval", StudyGoodInterval.ToString(), ref temp, Global.Deck_path + "setting.ini");
                StudyGoodInterval = int.Parse(temp.ToString());
                win32API.GetPrivateProfileString("Setting", "StudyEasyInterval", StudyEasyInterval.ToString(), ref temp, Global.Deck_path + "setting.ini");
                StudyEasyInterval = int.Parse(temp.ToString());
                win32API.GetPrivateProfileString("Setting", "AutoStudyInterval", AutoStudyInterval.ToString(), ref temp, Global.Deck_path + "setting.ini");
                AutoStudyInterval = int.Parse(temp.ToString());
                win32API.GetPrivateProfileString("Setting", "EnableBringExeTop", EnableBringExeTop.ToString(), ref temp, Global.Deck_path + "setting.ini");
                EnableBringExeTop = bool.Parse(temp.ToString());
                win32API.GetPrivateProfileString("Setting", "EnableAutoStudy", EnableAutoStudy.ToString(), ref temp, Global.Deck_path + "setting.ini");
                EnableAutoStudy = bool.Parse(temp.ToString());
                win32API.GetPrivateProfileString("Setting", "SoundVolume", SoundVolume.ToString(), ref temp, Global.Deck_path + "setting.ini");
                SoundVolume = int.Parse(temp.ToString());
            }
            catch (Exception ex)
            {
                WriteSettingToIni();    //Read fail, write default setting
                EventLog.Write("Read setting to ini fail, write default setting");
            }
        }
    }
}
