﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchefPovar
{
    public static class ExtentionMethodes
    {
        public static void PrintToConsole(this IList<IComponent> list)
        {
            foreach (var item in list)
            {

                Console.WriteLine(item.AllProperties);
            }

        }
        public static void CaloricContentToConsole(this ISalad salad)
        {
            Console.WriteLine("Калорийность салата -= {0} =- составляет - {1} ккал.", salad.GetName(), salad.CountCaloricContent());
        }
    }
}
