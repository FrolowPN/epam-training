using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class InputFileManager
    {
        public void AddInputFile(DateTime dateFile, string nameManager, IList<OrderWievModel> ordersWM)
        {
            var ctx = new BaseContext();
            ManagerHelper managerHelper = new ManagerHelper();
            OrderHelper orderHelper = new OrderHelper();
            InputFile inputFile = new InputFile()
                                                {
                                                    DateFile = dateFile,
                                                    IdManager = managerHelper.GetIdManager(nameManager),
                                                    Orders = orderHelper.ConvertWievToOrder(ordersWM)
                                                };
            ctx.InputFiles.Add(inputFile);
            ctx.SaveChanges();

        }
    }
}
