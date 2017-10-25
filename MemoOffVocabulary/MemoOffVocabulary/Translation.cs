using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

using HtmlAgilityPack;
using System.IO;

namespace MemoOffVocabulary
{
    class Translation
    {
        public static Dictionary<string, Func<object, bool>> TransMappingTable = new Dictionary<string, Func<object, bool>>()
        {
            { "Yahoo Dict (EN->CHT)" , TransYahooDictENToCHT},
            { "Google Trans (EN->CHT)" ,TransGoogleENToCHT},
            { "Google Trans (CHT->JP)" ,TransGoogleCHTToJP}
        };

        static bool TransYahooDictENToCHT(object param)
        {
            string keyword = (string)param;
            string downloadUrl = "https://tw.dictionary.search.yahoo.com/search?p="+ WebUtility.UrlEncode(keyword);
            MemoryStream RawMeanHTML = new MemoryStream();
            if (!WebCommon.WebClient_downloadData(ref RawMeanHTML, downloadUrl))
                return false;

            HtmlDocument doc = new HtmlDocument();
            doc.Load(RawMeanHTML, Encoding.UTF8);

            string TransText;

            return true;
        }
        static bool TransGoogleENToCHT(object param)
        {
            return true;
        }
        static bool TransGoogleCHTToJP(object param)
        {
            return true;
        }
    }
}
