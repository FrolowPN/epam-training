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
            //foreach (var item in temp.GetSortByCountAscending())
            //{
            //    Console.WriteLine(item.GetValue());
            //   // Console.WriteLine(item.Interrogative);
            //    Console.WriteLine(item.CountWord);
            //   //foreach (var word in item.Elements.Where(x => x.GetType() == typeof(Digit)))
            //   //{
            //   //    Console.Write(word.GetValue());
            //   //}
            //   //Console.WriteLine();
            //   //Console.WriteLine();
            //}
            foreach (var item in temp.GetWordGivenLength(12, false) )
            {
                Console.WriteLine(item.GetValue());
            }
            
            Console.ReadKey();

        }
    }
}
