using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOrder { get; set; }
        public int IdClient { get; set; }
        public string Product { get; set; }
        public double Cost { get; set; }
        public virtual File File { get; set; }
    }
}
