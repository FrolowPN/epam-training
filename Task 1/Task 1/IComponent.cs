using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public interface IComponent
    {
       string Name { get; set; }
      int CaloricContent { get; set; }
       void Print();
       
    }
}
