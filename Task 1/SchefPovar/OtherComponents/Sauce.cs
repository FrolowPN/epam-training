using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchefPovar
{
    public class Sauce: IComponent
    {
        public string Name { get; private set; }
        int Weight { get; set; }
        int FatContent { get; set; }
        int CaloricContentIn100gr { get; set; }
        public double CaloricContent { get; private set; }
        public string AllProperties { get; private set; }

        public Sauce()
        {
            Name = "Навание";
            Weight = 0;
            FatContent = 0;
            CaloricContent = 0;
            AllProperties = string.Format("- {0} \tвес - {1} гр. \tкалорийность - {2} ккал. \tжирность - {3}% ", Name, Weight, CaloricContent, FatContent);
        }
        public Sauce(string name, int weight, int fatContent, int caloricContentIn100gr)
        {
            Name = name;
            Weight = weight;
            CaloricContentIn100gr = caloricContentIn100gr;
            FatContent = fatContent;
            CaloricContent = (Weight*CaloricContentIn100gr)/100;
            AllProperties = string.Format("- {0} \tвес - {1} гр. \tкалорийность - {2:0.0} ккал. \tжирность - {3}% ", Name, Weight, CaloricContent, FatContent);
        }
        public void Rename(string name)
        {
            Name = name;
        }
        
    }
}
