using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = new Text(@"D:\VS\epam-training\Task 2\HandlerText\Files\Book.txt");
            foreach (var item in temp.GetSentences())
            {
               Console.WriteLine(item.Value);
               foreach (var word in item.Words)
               {
                   Console.WriteLine(word.Value);
               }
               foreach (var punctuationMark in item.PunctuationMarks)
               {
                   Console.WriteLine(punctuationMark.Value);
               }
            }
            
            Console.ReadKey();

        }
    }
}
