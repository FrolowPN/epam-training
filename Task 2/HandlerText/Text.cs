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
        IList<Word> Words { get; set; }
        public Text(string path)
        {
            ReadFile(path);
            ConvertToSentence();

        }
        public void ConvertToSentence()
        {
           var sentences = new List<Sentence>();
            foreach (var item in Value.Split('.'))
            {
                if (item !="")
                {
                 var temp = new Sentence(item.ToString());
                sentences.Add(temp);   
                }
            }
            Sentences = sentences;
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
