using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace MemoOffVocabulary
{
    class EventLog
    {
        public static string log_path { get; set; }

        public static void Write(string message)
        {
            if (string.IsNullOrEmpty(log_path))
                log_path = Directory.GetCurrentDirectory();
            
            if (!Directory.Exists(log_path))
                Directory.CreateDirectory(log_path);

            string file_name = log_path + "\\" + string.Format("EventLog_{0:yyyy-MM-dd}.txt", DateTime.Now);
            string log_line = string.Format("{0:yyyy/MM/dd HH:mm:ss} {1}", DateTime.Now, message) + Environment.NewLine;
            File.AppendAllText(file_name, log_line, Encoding.UTF8);
        }

    }
}
