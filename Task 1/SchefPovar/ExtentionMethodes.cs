using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchefPovar
{
    public static class ExtentionMethodes
    {
        public static void PrintToConsole (this List<IComponent> list)
        {
            foreach (var item in list)
            {

                Console.WriteLine(item.AllProperties);
            }
            
        }
        public static void CaloricContentToConsole(this Salad salad)
        {
            Console.WriteLine("Калорийность салата -= {0} =- составляет - {1} ккал.",salad.Name, salad.CountCaloricContent());
        }
    }
}
