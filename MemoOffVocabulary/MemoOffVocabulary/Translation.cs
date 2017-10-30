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
        public delegate bool FuncOut<T1, T2>(T1 param, out T2 output);

        public static Dictionary<string, FuncOut<object, string>> TransMappingTable = new Dictionary<string, FuncOut<object, string>>()
        {
            { "Yahoo Dict (EN->CHT)" , TransYahooDictENToCHT},
            { "Google Trans (EN->CHT)" ,TransGoogleENToCHT},
            { "Google Trans (CHT->JP)" ,TransGoogleCHTToJP}
        };

        static string DFS(HtmlNode NavNode)
        {
            if (NavNode.ChildNodes.Count == 0)
                return NavNode.InnerText;

            string output = "";
            HtmlNodeCollection NavNodeChilds = NavNode.ChildNodes;
            foreach (HtmlNode node in NavNodeChilds)
            {
                output += DFS(node);
            }

            return output;
        }

        static bool TransYahooDictENToCHT(object param,out string output)
        {
            output = "";

            string keyword = (string)param;
            string downloadUrl = "https://tw.dictionary.search.yahoo.com/search?p="+ WebUtility.UrlEncode(keyword);
            MemoryStream RawMeanHTML = new MemoryStream();
            if (!WebCommon.WebClient_downloadData(ref RawMeanHTML, downloadUrl))
                return false;

            HtmlDocument MeanHtmlDoc = new HtmlDocument();
            MeanHtmlDoc.Load(RawMeanHTML,Encoding.UTF8);

            HtmlNode NavNode = MeanHtmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"web\"]/ol[1]/li[2]/div/ul");
            if (NavNode==null || NavNode.ChildNodes.Count == 0)
                return false;

            HtmlNodeCollection NavNodeChilds = NavNode.ChildNodes;
            StringBuilder TransText = new StringBuilder();
            foreach (HtmlNode node in NavNodeChilds)                     //mean1, mean2, ...
            {
                if (node.ChildNodes.Count > 0)
                {
                    foreach (HtmlNode cnode in node.ChildNodes)         //line1, line2, ...
                    {
                        if(cnode.InnerText.Trim()!="")
                            TransText.Append(cnode.InnerText + "\r\n");
                    }
                }
                else
                    TransText.Append(node.InnerText);

                TransText.Append("\r\n");
            }

            output = TransText.ToString();
            return true;
        }
        static bool TransGoogleENToCHT(object param,out string output)
        {
            output = "";
            return true;
        }
        static bool TransGoogleCHTToJP(object param, out string output)
        {
            output = "";
            return true;
        }
    }
}
