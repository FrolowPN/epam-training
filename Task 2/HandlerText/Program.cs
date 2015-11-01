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
            IText temp = new Text(@"D:\VS\epam-training\Task 2\HandlerText\Files\Book.txt");
           temp.ChangeWordOnSubstring(2, 3, "CHANGED WORD");
            foreach (var item in temp.GetSentences())
            {
                foreach (var elem in item.GetElements())
                {
                    Console.Write(elem.GetValue());
                }
            }
           
            Console.ReadKey();

        }
    }
}
