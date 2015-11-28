using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class OrderWievModel
    {
        public DateTime DateOrder { get; set; }
        public string NameClient { get; set; }
        public string Product { get; set; }
        public double CostProduct { get; set; }
    }
}
