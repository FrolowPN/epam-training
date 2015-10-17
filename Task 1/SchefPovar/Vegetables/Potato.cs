using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchefPovar
{
    public class Potato: Vegetable, IComponent
    {
        public Potato(string name, int weight, int caloricContent)
            : base(name, weight, caloricContent)
        {

        }
    }
}
