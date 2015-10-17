using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchefPovar
{
    public static class ExtentionMethodes
    {
        public static void PrintToConsole (this IComponent item)
        {
            Console.WriteLine("Name - {0} \tКалорийность - {1} ккал.", item.Name, item.CaloricContent);
        }
    }
}
