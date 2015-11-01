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
        IList<ISentence> Sentences { get; set; }
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
        public IList<ISentence> GetSentences()
        {
            return Sentences;
        }
        public IList<ISentence> GetSortByCountAscending()
        {
            
            return Sentences.OrderBy(x => x.CountWord).ToList();
        }
        public IList<Word> GetWordGivenLength(int lengthWord, bool interrogative)
        {
            IList<ISentence> tempSentences = Sentences.Where(x => x.Interrogative == interrogative).ToList();
            List<Word> result = new List<Word>();
            
            if (tempSentences != null)
            {
                foreach (var item in tempSentences)
                {
                    foreach (Word word in item.GetElements().Where(x => x.GetType() == typeof(Word)).ToList())
                    {
                        if (word.CountLetter == lengthWord)
                        {int flag = 0;
                            foreach (var temper in result)
                            {
                                if (temper.GetValue() == word.GetValue())
                                {
                                    flag++;
                                }
                            }
                            if (flag == 0)
                            {
                               result.Add(word); 
                            }
                            else
                            {
                                flag = 0;
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
                foreach (Word word in item.GetElements().Where(x => x.GetType() == typeof(Word)).ToList())
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
        public void ChangeWordOnSubstring(int numberSentence, int lengthWord, string substring)
        {
            IList<IElement> elementOfSubstring = Parser.ParseToElements(substring);
            IList<IElement> temp = Sentences[numberSentence].Elements;
            IList<IElement> result = new List<IElement> { };
            foreach (var item in temp)
            {
                if (item.GetType()==typeof(Word))
                {
                    Word temper = (Word)item;
                    if (temper.CountLetter == lengthWord)
                    {
                        foreach (var element in elementOfSubstring)
                        {
                            result.Add(element);
                        }
                    }
                    else
                    {
                        result.Add(item);
                    }
                }
                else
                {
                    result.Add(item);      
                }
            }
            Sentences[numberSentence].SetElements(result);
        }
    }
}
