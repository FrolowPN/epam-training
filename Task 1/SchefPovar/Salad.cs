using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchefPovar
{
    public class Salad
    {
        public string Name { get; set; }
        public List<IComponent> Composition { get; set; }

        public Salad(string name, List<IComponent> list)
        {
            this.Name = name;
            this.Composition = list;

        }

       
        public void SortByName()
        {
            //foreach (var item in Composition.OrderBy(x=>x.Name))
            //{
            //    item.Print();
            //}
        }

        public void SortByCaloricContent()
        {
            //foreach (var item in Composition.OrderBy(x => x.CaloricContent))
            //{
            //    item.Print();
            //}
        }

        public int CountCaloricContent()
        {
            int amountOfCalories = 0;
            foreach (var item in Composition)
            {
             amountOfCalories += item.CaloricContent;
            }
            return amountOfCalories;
          
        }

        public void PrintComponentsWithParametrs(int begin, int end)
        {
            //foreach (var item in Composition.Where(x => x.CaloricContent >= begin && x.CaloricContent <= end))
            //{
            //    item.Print();
            //}
        }

    }
}
