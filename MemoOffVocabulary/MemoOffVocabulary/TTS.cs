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
            foreach (Tuple<string, string> o in ((Parameter)parameter).keyword_path_list)
            {
                WebClient webClient = new WebClient();
                switch (((Parameter)parameter).tts_type)
                { 
                    case TTS_type.GoogleTTS:
                        ((GoogleTTS)parameter).UpdateDownloadUrl(o.Item1);
                        try
                        {
                            webClient.DownloadFile(new Uri(((GoogleTTS)parameter).DownloadUrl), o.Item2);
                        }
                        catch (Exception e)
                        { }             //ignore
                        break;
                    default:
                        break;
                }
                Thread.Sleep(1000);
            }
        }
    }

    public class Parameter
    {
        public TTS_type tts_type;
        public string DownloadUrl_temp;
        public List<Tuple<string, string>> keyword_path_list;
    }

    public class GoogleTTS : Parameter
    {
        public string DownloadUrl;
        public GoogleTTS(TTS_type tts_type, List<Tuple<string, string>> keyword_path_list)
        {
            this.tts_type = tts_type;
            this.keyword_path_list = keyword_path_list;
            this.DownloadUrl_temp = "http://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q={TTS_Text}&tl=" + Global.TTS_speechtype.ToString();
        }

        public void UpdateDownloadUrl(string TTS_Text)
        {
            DownloadUrl = DownloadUrl_temp.Replace("{TTS_Text}", System.Uri.EscapeDataString(TTS_Text));
        }
    }

}
