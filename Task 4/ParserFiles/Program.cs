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

            //OrderHelper orderHelper = new OrderHelper();
            //OrderWievModel wiev = new OrderWievModel() { DateOrder = DateTime.Now, 
            //                                             NameClient = "First", 
            //                                             Product = "PC", 
            //                                             CostProduct = 123.5 };
            //orderHelper.AddOrder(wiev);

            InputFileManager inputFile = new InputFileManager();
            List<OrderWievModel> listOrders = new List<OrderWievModel> ()
            {
            new OrderWievModel() { DateOrder = DateTime.Now, NameClient = "First", Product = "PC", CostProduct = 123.5 },
            new OrderWievModel() { DateOrder = DateTime.Now, NameClient = "Two", Product = "Mouse", CostProduct = 54 },
            new OrderWievModel() { DateOrder = DateTime.Now, NameClient = "Three", Product = "Keyboard", CostProduct = 321.1 },
            new OrderWievModel() { DateOrder = DateTime.Now, NameClient = "Four", Product = "Monitor", CostProduct = 0.15 },
            new OrderWievModel() { DateOrder = DateTime.Now, NameClient = "Five", Product = "Chair", CostProduct = 152456 }
            };
            inputFile.AddInputFile(DateTime.Now, "Tester", listOrders);
        }
    }
}
