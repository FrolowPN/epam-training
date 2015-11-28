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
            //ManagerHelper manager = new ManagerHelper();
            //manager.AddManager("manager");
            //manager.RenameManager("manager","manamanager");
            //manager.DeleteManager("manager");

            //ClientHelper client = new ClientHelper();
            //client.AddClient("client");
            //client.DeleteClient("client");
            OrderHelper orderHelper = new OrderHelper();
            OrderWievModel wiev = new OrderWievModel() { DateOrder = DateTime.Now, 
                                                         NameClient = "First", 
                                                         Product = "PC", 
                                                         CostProduct = 123.5 };
            orderHelper.AddOrder(wiev);
        }
    }
}
