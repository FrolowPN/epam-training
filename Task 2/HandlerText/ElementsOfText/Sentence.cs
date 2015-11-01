using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public class Sentence : ISentence
    {
        string Value { get; set; }
        public IList<IElement> Elements { get; set; }
        public int CountWord { get { return Elements.Where(x => x.GetType() == typeof(Word)).Count(); } }
        public bool Interrogative
        {
            get
            {
                bool temp = false;
                if (Value[Value.Length - 1] == '?')
                {
                    temp = true;
                }
                return temp;
            }
        }

        public Sentence(string sentence)
        {

            Elements = Parser.ParseToElements(sentence);
        }

        public IList<IElement> GetElements()
        {
            return Elements;
        }

    }
}
