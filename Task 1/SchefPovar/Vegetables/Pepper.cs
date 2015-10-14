using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchefPovar
{
    public class Pepper : Vegetables, IComponent
    {
        public string Color { get; set; }

        public new void Print()
        {
            Console.WriteLine("- {0} \tВес - {1} г. \tКалорийность - {2} ккал. \tЦвет - {3}", Name, Weight, CaloricContent, Color);
        }
    }
}
