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
        public string AllProperties { get; private set; }

        public Oil()
        {
            Name = "Навание";
            Volume = 0;
            CaloricContent = 0;
            AllProperties = string.Format("- {0} \tвес - {1} гр. \tкалорийность - {2} ккал.", Name, Volume, CaloricContent);
        }
        public Oil(string name, int volume, int caloricContent)
        {
            Name = name;
            Volume = volume;
            CaloricContent = caloricContent;
            AllProperties = string.Format("- {0} \tвес - {1} гр. \tкалорийность - {2} ккал.", Name, Volume, CaloricContent);
        }
    }
}
