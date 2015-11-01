using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
   public static class Parser
    {
       public static IList<Sentence> ParseOnSentences(string text)
       {
           int beginSentence = 0;
           var sentences = new List<Sentence>();
           char[] endOfsentences = new char[] { '.', '!', '?' };
           for (int i = 0; i < text.Length; i++)
           {
               if (endOfsentences.Contains(text[i]))
               {
                   if (text[i] == '.' && i < text.Length - 2 && text[i + 1] == '.')
                   {
                       sentences.Add(new Sentence(text.Substring(beginSentence, i + 3 - beginSentence)));
                       beginSentence = i + 3;
                       i = i + 2;
                   }
                   else
                   {
                       sentences.Add(new Sentence(text.Substring(beginSentence, i + 1 - beginSentence)));
                       beginSentence = i + 1;
                   }
               }
           }
           return sentences;
       }
    }
}
