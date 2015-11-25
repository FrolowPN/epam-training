using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ManagerHelper
    {
        public void AddManager(string managerName)
        {
            BaseContext ctx = new BaseContext();
           Manager manager = new Manager() { Name = managerName };
            ctx.Managers.Add(manager);
            ctx.SaveChanges();
        }
        public bool ExistManager(string managerName)
        {
            BaseContext ctx = new BaseContext();
            int notExistManager = 0;
            return ctx.Managers.Where(x => x.Name == managerName).Count() != notExistManager;
        }
        public void DeleteManager(string managerName)
        {
            BaseContext ctx = new BaseContext();
            if (ExistManager(managerName))
            {
                ctx.Managers.Remove(GetManager(managerName));
                ctx.SaveChanges();
            }
        }
        public Manager GetManager(string nameManager)
        {
            BaseContext ctx = new BaseContext();
            if (ExistManager(nameManager))
            {
                return ctx.Managers.Where(x => x.Name == nameManager).FirstOrDefault();
            }
            else
            {
               Manager manager = new Manager() { Id = 00, Name = "Клиент не найден" };
                return manager;
            }
        }
        public void RenameManager(string oldNameManager, string newNameManager)
        {
            BaseContext ctx = new BaseContext();
            if (ExistManager(oldNameManager))
            {
                GetManager(oldNameManager).Name = newNameManager;
            }
            ctx.SaveChanges();
        }
    }
}
