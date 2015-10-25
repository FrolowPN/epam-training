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
        public Text(string path)
        {
            ReadFile(path);
            ConvertToSentence();

        }
        public void ConvertToSentence()
        {
            int beginSentence = 0;
            var sentences = new List<Sentence>();
            for (int i = 0; i < Value.Length; i++)
            {
                if (Value[i].ToString() == ".")
                {
                    if (i != Value.Length - 1)
                    {
                        if (Value[i].ToString() == "." && Value[i+1].ToString() == "." && Value[i+2].ToString() == ".")
                        {
                            var temp = new Sentence(Value.Substring(beginSentence, (i+2) - beginSentence + 1));
                        sentences.Add(temp);
                        if (i != Value.Length - 1)
                        {
                            beginSentence = i + 2;
                        }
                        }
                    }
                    else
                    {
                        var temp = new Sentence(Value.Substring(beginSentence, i - beginSentence + 1));
                        sentences.Add(temp);
                        if (i != Value.Length - 1)
                        {
                            beginSentence = i + 2;
                        }
                    }
                }
                else
                {
                    if (Value[i].ToString() == "!")
                    {
                        var temp = new Sentence(Value.Substring(beginSentence, i - beginSentence + 1));
                        sentences.Add(temp);
                        if (i != Value.Length - 1)
                        {
                            beginSentence = i + 2;
                        }
                    }
                    else
                    {
                        if (Value[i].ToString() == "?")
                        {
                            var temp = new Sentence(Value.Substring(beginSentence, i - beginSentence + 1));
                            sentences.Add(temp);
                            if (i != Value.Length - 1)
                            {
                                beginSentence = i + 1;
                            }
                        }
                        else
                        {

                        }
                    }
                }
            }
        }

        public void ReadFile(string pathfile)
        {
            StreamReader file = new StreamReader(pathfile);
            Value = file.ReadToEnd();
        }
        public IList<Sentence> GetSentences()
        {
            return Sentences;
        }
    }
}
