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
        public string AllProperties { get; private set; }

        public Sauce()
        {
            Name = "Навание";
            CaloricContent = 0;
            AllProperties = string.Format("- {0} \tкалорийность - {2} ккал.", Name, CaloricContent);
        }
        public Sauce(string name, int volume, int caloricContent)
        {
            Name = name;
            CaloricContent = caloricContent;
            AllProperties = string.Format("- {0} \tкалорийность - {2} ккал.", Name,  CaloricContent);
        }
        
    }
}
