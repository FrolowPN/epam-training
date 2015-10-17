using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchefPovar
{
    class Program
    {
        static void Main(string[] args)
        {
            var salad = new Salad("Все, что было", new List<IComponent>() { 
                                                        new Cucumber() { Name = "Салатный огурец", Weight = 100, CaloricContent = 120 },
                                                        new Onion() { Name = "Репчатый лук", Weight = 20, CaloricContent = 20 },
                                                        new Pepper() { Name = "Перец", Weight = 40, CaloricContent = 70, Color = "Красный" },
                                                        new Potato() { Name = "Отварной картофель", Weight = 200, CaloricContent = 400 },
                                                        new Tomato() { Name = "Черри", Weight = 80, CaloricContent = 30 },
                                                        new Potato() { Name = "Сырой картофель", Weight = 200, CaloricContent = 560 },
                                                        new Oil() { Name = "Оливковое масло",Volume = 40 , CaloricContent = 60 }
                                                        });

            Console.WriteLine("Состав салата -= {0} =-:", salad.Name);
            foreach (var item in salad.Composition)
            {
                ExtentionMethodes.PrintToConsole(item);
            }
            EmptyLineAndReadKey();
            ExtentionMethodes.CaloricContentToConsole(salad);
            EmptyLineAndReadKey();

            //salad.CountCaloricContent();
            //EmptyLineAndReadKey();

            //Console.WriteLine("Состав салата сортированнный по калорийности компонентов:");
            //salad.SortByCaloricContent();
            //EmptyLineAndReadKey();

            //Console.WriteLine("Состав салата сортированнный по названию компонентов:");
            //salad.SortByName();
            //EmptyLineAndReadKey();

            //int c = 50;
            //int b = 100;
            //Console.WriteLine("Состав салата отобранный по калорийности компонентов от {0} до {1} ккал.:", c, b);
            //salad.PrintComponentsWithParametrs(c, b);
            //Console.ReadKey();


        }

        public static void EmptyLineAndReadKey()
        {
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
