using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace MemoOffVocabulary
{
    static class RegexCommon
    {
        public static void Match(string src, ref List<string> dest, string pattern, RegexOptions opt = RegexOptions.Compiled | RegexOptions.Singleline)
        {
            Regex regex = new Regex(src, opt);
            foreach (Match m in regex.Matches(pattern))
            {
                if (m.Success)
                    dest.Add(m.Value);
            }
        }

        public static string Match(string src, string pattern, RegexOptions opt = RegexOptions.Compiled | RegexOptions.Singleline)
        {
            Regex regex = new Regex(src, opt);
            Match m = regex.Match(pattern);
            if (m.Success)
                return m.Value;
            
            return null;
        }

    }
}
