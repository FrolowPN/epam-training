using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public interface IText
    {
        IList<Sentence> GetSentences();
        IList<Sentence> GetSortByCountAscending();
        IList<Word> GetWordGivenLength(int lengthWord, bool interrogative);
        void RemoveWord(int lengthWord, bool consonant);
    }
}
