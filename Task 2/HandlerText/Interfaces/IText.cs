using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public interface IText
    {
        IList<ISentence> GetSentences();
        IList<ISentence> GetSortByCountAscending();
        IList<Word> GetWordGivenLength(int lengthWord, bool interrogative);
        void RemoveWord(int lengthWord, bool consonant);
        void ChangeWordOnSubstring(int numberSentence, int lengthWord, string substring);
    }
}
