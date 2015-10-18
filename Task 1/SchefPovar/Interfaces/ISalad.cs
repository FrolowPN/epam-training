using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchefPovar
{
    public interface ISalad
    {
        string GetName();
        IList<IComponent> GetAllComponents();
        bool DeleteComponent(string name);
        bool AddComponent(IComponent component);
        void SortByName();
        void SortByCaloricContent();
        double CountCaloricContent();
        IList<IComponent> ComponentsWithParametrs(int begin, int end);
        

    }
}
