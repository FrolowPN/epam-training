using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public class Sentence : ISentence
    {
        //string Value { get; set; }
        public IList<IElement> Elements { get; private set; }
        public int CountWord { get { return Elements.Where(x => x.GetType() == typeof(Word)).Count(); } }
        public bool Interrogative
        {
            get
            {
                bool temp = false;
                foreach (var item in Elements.Where(x => x.GetType() == typeof(PunctuationMark)))
                {
                  if (item.GetValue() == "?")
                {
                    temp = true;
                }
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

        public void SetElements(IList<IElement> elements) 
        {
            Elements = elements;
        }

    }
}
