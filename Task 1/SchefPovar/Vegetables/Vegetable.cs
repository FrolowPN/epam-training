using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchefPovar
{
    public class Vegetable : IComponent
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int CaloricContent { get; set; }
        public string AllProperties { get; protected set; }

        public Vegetable()
        {
            Name = "Навание";
            Weight = 0;
            CaloricContent = 0;
            AllProperties = string.Format("- {0} \tвес - {1} гр. \tкалорийность - {2} ккал.", Name, Weight, CaloricContent);
        }
        public Vegetable(string name, int weight, int caloricContent)
        {
            Name = name;
            Weight = weight;
            CaloricContent = caloricContent;
            AllProperties = string.Format("- {0} \tвес - {1} гр. \tкалорийность - {2} ккал.", Name, Weight, CaloricContent);
        }

    }
}
