using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
