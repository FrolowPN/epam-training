using BL;
using System;
using System.Collections.Generic;
using System.Configuration;
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
       
            //InputFileManager inputFile = new InputFileManager();
            //List<OrderWievModel> listOrders = new List<OrderWievModel> ()
            //{
            //new OrderWievModel() { DateOrder = DateTime.Parse("25-12-2015"), NameClient = "First", Product = "PC", CostProduct = 123.5 },
            //new OrderWievModel() { DateOrder = DateTime.Parse("25-12-2015"), NameClient = "Two", Product = "Mouse", CostProduct = 54 },
            //new OrderWievModel() { DateOrder = DateTime.Parse("25-12-2015"), NameClient = "Three", Product = "Keyboard", CostProduct = 321.1 },
            //new OrderWievModel() { DateOrder = DateTime.Parse("25-12-2015"), NameClient = "Four", Product = "Monitor", CostProduct = 0.15 },
            //new OrderWievModel() { DateOrder = DateTime.Parse("25-12-2015"), NameClient = "Five", Product = "Chair", CostProduct = 152456 }
            //};
            //InputFileWievModel inputWM = new InputFileWievModel(){DateFile = DateTime.Now, NameManager= "Tester"};
            //inputFile.AddInputFile(inputWM, listOrders);
            FileManager fileManager = new FileManager();
            List<string> resultFolder = new List<string>();
            fileManager.FindAllFolders(ConfigurationManager.AppSettings["InputFolder"], resultFolder);
            var result = fileManager.FindAllFiles(resultFolder);
            Parser parser = new Parser();
            InputFileManager inputFileManager = new InputFileManager();
            foreach (var item in result)
            {
               var parseNameFile = parser.ParseNameFile(fileManager.GetNameFile(item));
               var parseFile = parser.ParseFile(item);
               inputFileManager.AddInputFile(parseNameFile, parseFile);
               Console.WriteLine(fileManager.GetNameFile(item)+" - обработан");
            }
            Console.ReadKey();
        }
    }
}
