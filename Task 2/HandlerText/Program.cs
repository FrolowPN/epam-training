using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace HandlerText
{
    class Program
    {
        static void Main(string[] args)
        {
            IText temp = new Text(ConfigurationManager.AppSettings["InputFile"]);
            using (StreamWriter file = new StreamWriter(ConfigurationManager.AppSettings["OutputFile"], false))
            {

                file.WriteLine("Вывод предлождений отсортированных по количеству слов!");
                file.WriteLine("--------------------------------------------------------------------");
                foreach (var item in temp.GetSortByCountAscending())
                {
                    foreach (var element in item.Elements)
                    {
                        file.Write(element.GetValue());
                    }
                    file.WriteLine();
                    file.WriteLine("Количество слов = {0} \n", item.CountWord);
                }
                file.WriteLine("Вывод слов заданной длины без повторений из вопросительных предложений!");
                file.WriteLine("--------------------------------------------------------------------");
                foreach (var item in temp.GetWordGivenLength(5, true))
                {
                    file.WriteLine(item.GetValue() + " ");
                }
                file.WriteLine("\n");

                file.WriteLine("Замена в предложении данного номера слов данной длинны на заданную подстроку!");
                file.WriteLine("--------------------------------------------------------------------");
                temp.ChangeWordOnSubstring(2, 3, "CHANGED WORD");
                foreach (var item in temp.GetSentences())
                {
                    foreach (var elem in item.GetElements())
                    {
                        file.Write(elem.GetValue());
                    }
                }

                file.WriteLine("\n");

                file.WriteLine("Удаление слов заданной длины начинающихся на согласную букву");
                file.WriteLine("--------------------------------------------------------------------");
                temp.RemoveWord(3, true);
                foreach (var item in temp.GetSentences())
                {
                    foreach (var elem in item.GetElements())
                    {
                        file.Write(elem.GetValue());
                    }
                }
            }
        }
    }
}
