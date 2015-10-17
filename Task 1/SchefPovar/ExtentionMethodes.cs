using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchefPovar
{
    public static class ExtentionMethodes
    {
        public static void PrintToConsole (this Vegetable item)
        {
            Console.WriteLine("- {0} \tВес - {1} г. \tКалорийность - {2} ккал.", item.Name, item.Weight, item.CaloricContent);
        }
    }
}
