using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Vegetables: IComponent
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int CaloricContent { get; set; }
        public Vegetables()
        {
                
        }
        public Vegetables(string name, double weight, int caloricContent)
        {
            Name = name;
            Weight = weight;
            CaloricContent = caloricContent;
        }
        public void Print()
        {
            Console.WriteLine("Название - {0} \tВес - {1} г. \tКалорийность - {2} ккал.", Name, Weight, CaloricContent);
        }

    }
}
