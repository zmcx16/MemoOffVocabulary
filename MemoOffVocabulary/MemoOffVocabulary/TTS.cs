using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using System.Threading;

namespace MemoOffVocabulary
{
    public enum TTS_type { GoogleTTS };

    public static class TTS
    {
        public static void DownLoadTTS(Object parameter) 
        {
            foreach (Tuple<string, string, string> o in ((Parameter)parameter).KeywordPathSpeechtype_list)
            {
                WebClient webClient = new WebClient();
                switch (((Parameter)parameter).tts_type)
                { 
                    case TTS_type.GoogleTTS:
                        ((GoogleTTS)parameter).UpdateDownloadUrl(o.Item1, o.Item3);
                        try
                        {
                            webClient.DownloadFile(new Uri(((GoogleTTS)parameter).DownloadUrl), o.Item2);
                        }
                        catch (Exception ex)
                        {
                            EventLog.Write("Fail download Google TTS, ignore fail download");
                        }
                        break;
                    default:
                        break;
                }
                Thread.Sleep(1000);
            }
        }

        public static void DownloadTTSThread(List<Tuple<string, string, string>> KeywordPathSpeechtype_list)
        {
            GoogleTTS tts_paramter = new GoogleTTS(TTS_type.GoogleTTS, KeywordPathSpeechtype_list);
            Thread t = new Thread(TTS.DownLoadTTS);
            t.IsBackground = true;
            t.Start(tts_paramter);
        }

        public static void DownloadTTSThread(string keyword, string CardFile_Path, string TTS_speechtype)
        {
            List<Tuple<string, string, string>> KeywordPathSpeechtype_list = new List<Tuple<string, string, string>>();
            KeywordPathSpeechtype_list.Add(new Tuple<string, string, string>(keyword, CardFile_Path, TTS_speechtype));
            DownloadTTSThread(KeywordPathSpeechtype_list);
        }
    }

    public class Parameter
    {
        public TTS_type tts_type;
        public string DownloadUrl_temp;
        public List<Tuple<string, string, string>> KeywordPathSpeechtype_list;
    }

    public class GoogleTTS : Parameter
    {
        public string DownloadUrl;
        public GoogleTTS(TTS_type tts_type, List<Tuple<string, string, string>> KeywordPathSpeechtype_list)
        {
            this.tts_type = tts_type;
            this.KeywordPathSpeechtype_list = KeywordPathSpeechtype_list;
            this.DownloadUrl_temp = "http://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q={TTS_Text}&tl={Speechtype}";
        }

        public void UpdateDownloadUrl(string TTS_Text, string Speechtype)
        {
            DownloadUrl = DownloadUrl_temp.Replace("{TTS_Text}", System.Uri.EscapeDataString(TTS_Text));
            DownloadUrl = DownloadUrl.Replace("{Speechtype}", Speechtype);
        }
    }

}
