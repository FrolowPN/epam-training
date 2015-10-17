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
        private List<IComponent> Composition { get; set; }

        public Salad(string name, List<IComponent> list)
        {
            Name = name;
            Composition = list;
        }
        public List<IComponent> GetAllComponents() 
        {
            return Composition;
        }
        public bool DeleteComponent(string name)
        {
            try
            {
                Composition.Remove(Composition.Where(x => x.Name == name).FirstOrDefault());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddComponent(IComponent component)
        {
            try
            {
                Composition.Add(component);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
      
        public void SortByName()
        {
            Composition = Composition.OrderBy(x => x.Name).ToList();
        }

        public void SortByCaloricContent()
        {
            this.Composition = Composition.OrderBy(x => x.CaloricContent).ToList();
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

        public List<IComponent> ComponentsWithParametrs(int begin, int end)
        {
            List<IComponent> list = this.Composition.Where(x => x.CaloricContent >= begin && x.CaloricContent <= end).ToList();
            return list;
        }

    }
}
