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
        public IList<PunctuationMark> PunctuationMarks { get; set; }
        public int CountWord { get { return Words.Count(); } }
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
            var words = new List<Word>();
            var marks = new List<PunctuationMark>();
            char[] characters = new char[] { ' ', ',', ':', ';', '"', '-' };
            char[] endOfsentences = new char[] { '.', '!', '?' };
            for (int i = 0; i < Value.Length; i++)
            {
                if (characters.Contains(Value[i]) || endOfsentences.Contains(Value[i]))
                {
                    if (Value[i] == '.')
                    {
                        if (i <= (Value.Length - 3))
                        {
                            if (Value[i + 1] == '.')
                            {
                                var tempCharacter = new PunctuationMark(Value.Substring(i, 3));
                                marks.Add(tempCharacter);
                                var tempWord = new Word(Value.Substring(beginWord, i - beginWord));
                                words.Add(tempWord);
                                i = i + 2;
                            }
                        }
                        else
                        {
                            var tempCharacter = new PunctuationMark(Value[i].ToString());
                            marks.Add(tempCharacter);
                            var tempWord = new Word(Value.Substring(beginWord, i - beginWord));
                            words.Add(tempWord);
                        }
                    }
                    else
                    {
                        if (Value[i] == ' ')
                        {
                            var tempWord = new Word(Value.Substring(beginWord, i - beginWord));
                            words.Add(tempWord);
                            if (i < Value.Length - 1)
                            {
                                beginWord = i + 1;

                            }
                        }
                        else
                        {
                            if (Value[i] == '"')
                            {
                                if (Value[i - 1] == ' ')
                                {
                                    var tempCharacter = new PunctuationMark(Value[i].ToString());
                                    marks.Add(tempCharacter);
                                    if (i < Value.Length - 1)
                                    {
                                        beginWord = i + 1;
                                    }
                                }
                                else
                                {
                                    var tempCharacter = new PunctuationMark(Value[i].ToString());
                                    marks.Add(tempCharacter);
                                    var tempWord = new Word(Value.Substring(beginWord, i - beginWord));
                                    words.Add(tempWord);
                                    if (i < Value.Length - 1)
                                    {
                                        beginWord = i + 1;
                                    }
                                }

                            }
                            else
                            {
                                var tempCharacter = new PunctuationMark(Value[i].ToString());
                                marks.Add(tempCharacter);
                                var tempWord = new Word(Value.Substring(beginWord, i - beginWord));
                                words.Add(tempWord);
                                if (i < Value.Length - 1)
                                {
                                    beginWord = i + 2;
                                    i = i + 1;
                                }
                            }
                        }
                    }
                }
            }
            Words = words;
            PunctuationMarks = marks;
        }

        public IList<Word> GetWords()
        {
            return Words;
        }
    }
}
