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
            var temp = new Text();
            temp.ReadFile(@"D:\VS\epam-training\Task 2\HandlerText\Files\Book.txt");
            temp.ConvertToSentence();
            Console.WriteLine(temp.Value);
            Console.ReadKey();

        }
    }
}
