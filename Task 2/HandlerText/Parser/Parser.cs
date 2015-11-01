using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
   public static class Parser
    {
       public static IList<ISentence> ParseOnSentences(string text)
       {
           int beginSentence = 0;
           var sentences = new List<ISentence>();
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

       public static IList<IElement> ParseToElements(string sentence)
       {
           int beginWord = 0;
           var elements = new List<IElement>();
           char[] characters = new char[] { ' ', ',', ':', ';', '"', '-', '.', '!', '?', 
                                             '(', ')' , '\r', '\n', '0', '1', '2', '3', 
                                              '4', '5', '6', '7', '8', '9'};

           char[] singleChars = new char[] { ' ', '"', '-', '(', '\r', '\n' };
           char[] digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
           for (int i = 0; i < sentence.Length; i++)
           {
               if (characters.Contains(sentence[i]))
               {
                   if (singleChars.Contains(sentence[i]) && beginWord == i)
                   {
                       elements.Add(new PunctuationMark(sentence[i].ToString()));
                       beginWord = i + 1;
                   }
                   else if (digits.Contains(sentence[i]) && beginWord == i)
                   {
                       elements.Add(new Digit(sentence[i].ToString()));
                       beginWord = i + 1;
                   }
                   else if (sentence[i] == '.' && i < sentence.Length - 2 && sentence[i + 1] == '.')
                   {
                       if ((i - beginWord) != 0)
                       {
                           elements.Add(new Word(sentence.Substring(beginWord, i - beginWord)));
                       }
                       elements.Add(new PunctuationMark(sentence.Substring(i, 3)));
                       beginWord = i + 3;
                       i += 2;
                   }
                   else
                   {
                       if ((i - beginWord) != 0)
                       {
                           elements.Add(new Word(sentence.Substring(beginWord, i - beginWord)));
                       }
                       elements.Add(new PunctuationMark(sentence[i].ToString()));
                       beginWord = i + 1;
                   }
               }
               else if (i == sentence.Length-1)
               {
                   elements.Add(new Word(sentence.Substring(beginWord, i - beginWord+1)));  
               }
           }
           return elements;
       }
    }
}
