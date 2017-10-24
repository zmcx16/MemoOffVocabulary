using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;

namespace MemoOffVocabulary
{
    class WebCommon
    {
        public static bool WebClient_downloadData(ref string download_data, string download_url, string Encoding= "UTF8")
        {
            try
            {
                WebClient wc = new WebClient();
                byte[] b = wc.DownloadData(download_url);
                if (Encoding == "Default")
                    download_data = System.Text.Encoding.Default.GetString(b);
                else if (Encoding == "UTF8")
                    download_data = System.Text.Encoding.UTF8.GetString(b);
            }
            catch (Exception ex)
            {
                EventLog.Write(ex.ToString());
                return false;
            }
            return true;
        }

    }
}
