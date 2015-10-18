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
        public int Weight { get; set; }
        public int CaloricContentIn100gr { get; set; }
        public double CaloricContent { get; set; }
        public string AllProperties { get; private set; }

        public Sauce()
        {
            Name = "Навание";
            CaloricContent = 0;
            AllProperties = string.Format("- {0} \tкалорийность - {2} ккал.", Name, CaloricContent);
        }
        public Sauce(string name, int weight, int caloricContentIn100gr)
        {
            Name = name;
            Weight = Weight;
            CaloricContentIn100gr = caloricContentIn100gr;
            CaloricContent = (Weight*CaloricContentIn100gr)/100;
            AllProperties = string.Format("- {0} \tкалорийность - {2:0.0} ккал.", Name,  CaloricContent);
        }
        
    }
}
