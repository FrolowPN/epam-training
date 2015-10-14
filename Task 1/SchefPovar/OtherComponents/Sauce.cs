using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchefPovar
{
    public class Sauce: IComponent
    {
        public string Name { get; set; }
        public int CaloricContent { get; set; }

        public void Print()
        {
            Console.WriteLine("Заправка - {0} \tКалорийность - {1} ккал.", Name, CaloricContent);
        }
    }
}
