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
            Console.WriteLine("Вывод предлождений отсортированных по количеству слов!");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (var item in temp.GetSortByCountAscending())
            {
                foreach (var element in item.Elements)
                {
                    Console.Write(element.GetValue());
                }
                Console.WriteLine();
                Console.WriteLine("Количество слов = {0} \n", item.CountWord);
            }
            Console.WriteLine("Вывод слов заданной длины без повторений из вопросительных предложений!");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (var item in temp.GetWordGivenLength(5, true))
            {
                Console.WriteLine(item.GetValue()+ " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Замена в предложении данного номера слов данной длинны на заданную подстроку!");
            Console.WriteLine("--------------------------------------------------------------------");
            temp.ChangeWordOnSubstring(2, 3, "CHANGED WORD");
            foreach (var item in temp.GetSentences())
            {
                foreach (var elem in item.GetElements())
                {
                    Console.Write(elem.GetValue());
                }
            }

            Console.WriteLine("\n");

            Console.WriteLine("Удаление слов заданной длины начинающихся на согласную букву");
            Console.WriteLine("--------------------------------------------------------------------");
            temp.RemoveWord(3, true);
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
