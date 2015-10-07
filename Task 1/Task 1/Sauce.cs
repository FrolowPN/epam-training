using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Sauce: IComponent
    {
        public string Name { get; set; }
        public int CaloricContent { get; set; }
        public void Print()
        {
            Console.WriteLine("Название заправки - {0} \tКалорийность - {1}", Name, CaloricContent);
        }
    }
}
