using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoOffVocabulary
{
    public class VocabularyStructure
    {
        public string timestamp;
        public string keyword;
        public string valueword;

        public VocabularyStructure(string timestamp, string keyword, string valueword) {
            this.timestamp = timestamp;
            this.keyword = keyword;
            this.valueword = valueword;
        }
    }

    public class DeckStructure
    {
        public string keyword;
        public string valueword;
        public DeckStructure(string keyword, string valueword)
        {
            this.keyword = keyword;
            this.valueword = valueword;
        }
    }

}
