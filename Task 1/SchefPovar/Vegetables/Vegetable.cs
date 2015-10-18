using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchefPovar
{
    public class Vegetable : IComponent
    {
        public string Name { get; protected set; }
        protected int Weight { get; set; }
        protected int CaloricContentIn100gr { get; set; }
        public double CaloricContent { get; protected set; }
        public string AllProperties { get; protected set; }

        public Vegetable()
        {
            Name = "Навание";
            Weight = 0;
            CaloricContentIn100gr = 0;
            CaloricContent = 0; CaloricContent = (Weight / 100) * CaloricContentIn100gr; 
            AllProperties = string.Format("- {0} \tвес - {1} гр. \tкалорийность - {2} ккал.", Name, Weight, CaloricContent);
        }
        public Vegetable(string name, int weight, int caloricContentIn100gr)
        {
            Name = name;
            Weight = weight;
            CaloricContentIn100gr = caloricContentIn100gr;
            CaloricContent = (Weight * CaloricContentIn100gr)/100;
            AllProperties = string.Format("- {0} \tвес - {1} гр. \tкалорийность - {2:0.0} ккал.", Name, Weight, CaloricContent);
        }

        public void Rename(string name) 
        {
            Name = name;
        }

    }
}
