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
                                                        new Cucumber("Салатный огурец", 100, 120 ),
                                                        new Onion("Репчатый лук", 20, 20) ,
                                                        new Pepper("Перец", 40, 70,"Красный"),
                                                        new Potato("Отварной картофель",200,400),
                                                        new Tomato("Черри", 80, 30),
                                                        new Potato("Сырой картофель", 200, 560),
                                                        new Oil("Оливковое масло",40 , 60)
                                                        });

            Console.WriteLine("Состав салата -= {0} =-:", salad.Name);
            ExtentionMethodes.PrintToConsole(salad.Composition);
            EmptyLineAndReadKey();

            ExtentionMethodes.CaloricContentToConsole(salad);
            EmptyLineAndReadKey();

            salad.SortByName();
            ExtentionMethodes.PrintToConsole(salad.Composition);
            EmptyLineAndReadKey();

            salad.SortByCaloricContent();
            ExtentionMethodes.PrintToConsole(salad.Composition);
            EmptyLineAndReadKey();
                        
            int c = 20;
            int b = 100;
            Console.WriteLine("Состав салата отобранный по калорийности компонентов от {0} до {1} ккал.:", c, b);
            ExtentionMethodes.PrintToConsole(salad.ComponentsWithParametrs(c, b));
            Console.ReadKey();


        }

        public static void EmptyLineAndReadKey()
        {
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
