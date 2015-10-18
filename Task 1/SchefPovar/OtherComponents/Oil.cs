using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchefPovar
{
    public class Oil : IComponent
    {
        public string Name { get; private set; }
        int CaloricContentIn100ml { get; set; }
        public double CaloricContent { get; private set; }
        int Volume { get; set; }
        public string AllProperties { get; private set; }

        public Oil()
        {
            Name = "Навание";
            Volume = 0;
            CaloricContentIn100ml = 0;
            CaloricContent = 0;
            AllProperties = string.Format("- {0} \tобъем - {1} мл. \tкалорийность - {2} ккал.", Name, Volume, CaloricContent);
        }
        public Oil(string name, int volume, int caloricContentIn100ml)
        {
            Name = name;
            Volume = volume;
            CaloricContentIn100ml = caloricContentIn100ml;
            CaloricContent = (Volume*CaloricContentIn100ml)/100;
            AllProperties = string.Format("- {0} \tобъем - {1} мл. \tкалорийность - {2:0.0} ккал.", Name, Volume, CaloricContent);
        }
        public void Rename(string name)
        {
            Name = name;
        }
    }
}
