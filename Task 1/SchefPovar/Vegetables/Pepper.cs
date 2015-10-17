using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchefPovar
{
    public class Pepper : Vegetable, IComponent
    {
        public string Color { get; set; }
        
        public Pepper(string name, int weight, int caloricContent, string color)
            : base(name, weight, caloricContent)
        {
            Color = color;
            AllProperties = string.Format("- {0} \tвес - {1} гр. \tкалорийность - {2} ккал. \tцвет - {3}", Name, Weight, CaloricContent, Color);
        }
        
      
    }
}
