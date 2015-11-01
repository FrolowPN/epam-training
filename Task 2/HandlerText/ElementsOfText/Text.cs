using System;
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
            Sentences = Parser.ParseOnSentences(GetTextFromFile(path));
            
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
                    foreach (Word word in item.Elements.Where(x => x.GetType() == typeof(Word)).ToList())
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
            return result;
        }
        public void RemoveWord(int lengthWord, bool consonant)
        {
            List<Word> result = new List<Word>();
            foreach (var item in Sentences)
            {
                foreach (Word word in item.Elements.Where(x => x.GetType() == typeof(Word)).ToList())
                {
                    if (word.CountLetter == lengthWord)
                    {
                        if (word.BeginWithConsonant == consonant)
                        {
                            item.Elements.Remove(word);
                        }
                    }
                }
            }
        }
    }
}
