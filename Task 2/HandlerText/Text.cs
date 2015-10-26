using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public class Text
    {
        string Value { get; set; }
        IList<Sentence> Sentences { get; set; }
        public int CountSentence { get { return Sentences.Count(); } }
        public Text(string path)
        {
            Value = GetTextFromFile(path);
            ConvertToSentence();
        }
        public void ConvertToSentence()
        {
            int beginSentence = 0;
            var sentences = new List<Sentence>();
            char[] endOfsentences = new char[] { '.', '!', '?' };
            for (int i = 0; i < Value.Length; i++)
            {
                if (endOfsentences.Contains(Value[i]))
                {
                    if (Value[i] == '.')
                    {
                        if (i < (Value.Length - 2))
                        {
                            if (Value[i + 1] == '.')
                            {
                                var temp = new Sentence(Value.Substring(beginSentence, (i + 2 - beginSentence) + 1));
                                sentences.Add(temp);
                                if (i != Value.Length - 1)
                                {
                                    beginSentence = i + 4;
                                    i = i + 4;
                                }
                            }
                            else
                            {
                                var temp = new Sentence(Value.Substring(beginSentence, (i - beginSentence) + 1));
                                sentences.Add(temp);
                                if (i != Value.Length - 1)
                                {
                                    beginSentence = i + 2;
                                }
                            }
                        }
                    }
                    else
                    {
                        var temp = new Sentence(Value.Substring(beginSentence, (i - beginSentence) + 1));
                        sentences.Add(temp);
                        if (i != Value.Length - 1)
                        {
                            beginSentence = i + 2;
                        }
                    }
                }
            }
            Sentences = sentences;
        }

        public string GetTextFromFile(string pathfile)
        {
            StreamReader file = new StreamReader(pathfile);
            var temp = file.ReadToEnd();
            string result = "";
            for (int i = 0; i < temp.Length; i++)
            {
                if (i < temp.Length - 1)
                {
                    if (temp[i] == ' ' && temp[i + 1] == ' ')
                    {
                        
                    }
                    else
                    {
                        result += temp[i];
                    }
                }
                else
                {
                    result += temp[i];
                }
            }
            return result;
        }
        public IList<Sentence> GetSentences()
        {
            return Sentences;
        }
    }
}
