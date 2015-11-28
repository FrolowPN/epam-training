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
        public void AddInputFile(InputFileWievModel inputWM, IList<OrderWievModel> ordersWM)
        {
            var ctx = new BaseContext();
            ManagerHelper managerHelper = new ManagerHelper();
            OrderHelper orderHelper = new OrderHelper();
            InputFile inputFile = new InputFile()
                                                {
                                                    DateFile = inputWM.DateFile,
                                                    IdManager = managerHelper.GetIdManager(inputWM.NameManager),
                                                    Orders = orderHelper.ConvertWievToOrder(ordersWM)
                                                };
            ctx.InputFiles.Add(inputFile);
            ctx.SaveChanges();

        }
    }
}
