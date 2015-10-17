using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchefPovar
{
    public class Vegetable: IComponent
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int CaloricContent { get; set; }

        public void Print()
        {
            Console.WriteLine("- {0} \tВес - {1} г. \tКалорийность - {2} ккал.", Name, Weight, CaloricContent);
        }

    }
}
