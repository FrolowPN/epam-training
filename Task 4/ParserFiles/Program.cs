using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerHelper manager = new ManagerHelper();
            manager.AddManager("manager");
            manager.RenameManager("manager","manamanager");
        }
    }
}
