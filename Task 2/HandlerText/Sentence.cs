using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public class Sentence
    {
        public string Value { get; set; }
        public IList<Word> Words { get; set; }
        public Sentence(string value)
        {
            Value = value;
            ConvertToWord();
        }
        public void ConvertToWord()
        {
            var words = new List<Word>();
            foreach (var item in Value.Split(' '))
            {
                if (item != "")
                {
                    var temp = new Word(item.ToString());
                    words.Add(temp);
                }
            }
            Words = words;
        }
       
        public IList<Word> GetWords()
        {
            return Words;
        }
    }
}
