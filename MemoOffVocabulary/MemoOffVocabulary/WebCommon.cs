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
        public static bool WebClient_downloadData(ref MemoryStream download_data, string download_url)
        {
            try
            {
                WebClient wc = new WebClient();
                download_data = new MemoryStream(wc.DownloadData(download_url));
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
