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
        public IList<IElement> Elements { get; set; }
        //public IList<Word> Words { get; set; }
        //public IList<PunctuationMark> PunctuationMarks { get; set; }
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

        public Sentence(string value)
        {
            Value = value;
            ConvertToWordAndMark();
        }
        public void ConvertToWordAndMark()
        {
            int beginWord = 0;
            var elements = new List<IElement>();
            char[] characters = new char[] { ' ', ',', ':', ';', '"', '-', '.', '!', '?', '(' , ')' };
            for (int i = 0; i < Value.Length; i++)
            {
                if (characters.Contains(Value[i]))
                {
                    if ((Value[i] == ' ' || Value[i] == '"' || Value[i] == '(') && beginWord == i)
                    {
                        elements.Add(new PunctuationMark(Value[i].ToString()));
                        beginWord = i+1;
                    }
                    else if (Value[i]=='.' && i<Value.Length-2 && Value[i+1]=='.')
                    {
                        if ((i - beginWord)!=0)
                        {
                            elements.Add(new Word(Value.Substring(beginWord, i - beginWord)));  
                        }
                        elements.Add(new PunctuationMark(Value.Substring(i, 3)));
                        beginWord = i+3;
                        i+=2;
                    }
                    else 
                    {
                        elements.Add(new Word(Value.Substring(beginWord, i - beginWord)));
                        elements.Add(new PunctuationMark(Value[i].ToString()));
                        beginWord = i+1; 
                    }
                }
            }
            Elements = elements;
        }
      
        //public IList<Word> GetWords()
        //{
        //    return Words;
        //}
    }
}
