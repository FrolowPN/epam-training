﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public class Text : IText
    {
        string Value { get; set; }
        IList<Sentence> Sentences { get; set; }
        public int CountSentence { get { return Sentences.Count(); } }
        public Text(string path)
        {
            Value = GetTextFromFile(path);
            Sentences = ConvertToSentence(Value);
        }
        public IList<Sentence> ConvertToSentence(string text)
        {
            int beginSentence = 0;
            var sentences = new List<Sentence>();
            char[] endOfsentences = new char[] { '.', '!', '?' };
            for (int i = 0; i < Value.Length; i++)
            {
                if (endOfsentences.Contains(Value[i]))
                {
                    if (Value[i] == '.' && i < Value.Length - 2 && Value[i + 1] == '.')
                    {
                        sentences.Add(new Sentence(Value.Substring(beginSentence, i + 3 - beginSentence)));
                        beginSentence = i + 3;
                        i = i + 2;
                    }
                    else
                    {
                        sentences.Add(new Sentence(Value.Substring(beginSentence, i + 1 - beginSentence)));
                        beginSentence = i + 1;
                    }
                }
            }
            return sentences;
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
        public IList<Sentence> GetSortByCountAscending()
        {
            return Sentences.OrderBy(x => x.CountWord).ToList();
        }
        public IList<Word> GetWordGivenLength(int lengthWord, bool interrogative)
        {
            IList<Sentence> tempSentences = Sentences.Where(x => x.Interrogative == interrogative).ToList();
            List<Word> result = new List<Word>();
            if (tempSentences != null)
            {
                foreach (var item in tempSentences)
                {
                    IList<Word> tempWords = (IList<Word>)item.Elements.Where(x => x.GetType() == typeof(Word)).ToList();
                    if (tempWords != null)
                    {
                        foreach (Word word in tempWords)
                        {
                            if (word.CountLetter == lengthWord)
                            {
                                if (!result.Contains(word))
                                {
                                    result.Add(word);
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
