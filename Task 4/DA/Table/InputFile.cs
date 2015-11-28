using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class InputFile
    {
        public int Id { get; set; }
        public int IdManager { get; set; }
        public DateTime DateFile { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
