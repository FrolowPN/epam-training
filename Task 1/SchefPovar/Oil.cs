using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchefPovar
{
    public class Oil : IComponent
    {
        public string Name { get; set; }
        public int CaloricContent { get; set; }
        public int Volume { get; set; }
        
        public void Print()
        {
            Console.WriteLine("Заправка - {0} \t Объем - {1} мл. \tКалорийность - {2} ккал.", Name, Volume, CaloricContent);
        }
    }
}
