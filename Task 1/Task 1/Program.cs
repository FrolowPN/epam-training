using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var salad = new Salad();
            salad.Name = "Все, что было";
            
            var components = new List<IComponent>();
            components.Add(new Cucumber() { Name = "Салатный огурец", Weight = 100, CaloricContent = 120 });
            components.Add(new Onion() { Name = "Репчатый лук", Weight = 20, CaloricContent = 20 });
            components.Add(new Pepper() { Name = "Красный перец", Weight = 40, CaloricContent = 70 });
            components.Add(new Potato() { Name = "Отварной картофель", Weight = 200, CaloricContent = 400 });
            components.Add(new Tomato() { Name = "Черри", Weight = 80, CaloricContent = 30 });
            components.Add(new Potato() { Name = "Сырой картофель", Weight = 200, CaloricContent = 560 });
            components.Add(new Oil() { Name = "Оливковое масло", CaloricContent = 60 });
            
            salad.Composition = components;

            Console.WriteLine("Состав салата -= {0} =-:", salad.Name);
            foreach (var item in salad.Composition)
            {
                item.Print();
            }
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine("Состав салата сортированнный по названию компонентов:");
            
            foreach (var item in salad.Composition.OrderBy(x => x.Name))
            {
                item.Print();
            }
            Console.WriteLine("");
            Console.ReadKey();

            int c = 50;
            int b = 100;
            Console.WriteLine("Состав салата отобранный по калорийности компонентов от {0} до {1} ккал.:", c, b);

            foreach (var item in salad.Composition.Where(x => x.CaloricContent > c && x.CaloricContent < b))
            {
                item.Print();
            }
            Console.ReadKey();
        }
    }
}
