using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClientHelper
    {
        public void AddClient(string clientName)
        {
            BaseContext ctx = new BaseContext();
            Client client = new Client() { Name = clientName};
            ctx.Clients.Add(client);
            ctx.SaveChanges();
        }
        public bool ExistClient(string clientName)
        {
            BaseContext ctx = new BaseContext();
            int notExistClient = 0;
            return ctx.Clients.Where(x => x.Name == clientName).Count() != notExistClient;
        }
        public void DeleteClient(string clientName)
        {
            BaseContext ctx = new BaseContext();
            if (ExistClient(clientName))
            {
                 ctx.Clients.Remove(ctx.Clients.Where(x => x.Name == clientName).FirstOrDefault());
                ctx.SaveChanges();
            }
        }
        public Client GetClient(string nameClient)
        {
            BaseContext ctx = new BaseContext();
            if (ExistClient(nameClient))
            {
                var temper = ctx.Clients.Where(x => x.Name == nameClient).FirstOrDefault();
                return temper;
            }
            else
            {
                Client client = new Client() { Id = 00, Name = "Клиент не найден" };
                return client;
            }
        }
        public void RenameClient(string oldNameClient, string newNameClient)
        {
            BaseContext ctx = new BaseContext();
            if (ExistClient(oldNameClient))
            {
              ctx.Clients.Where(x => x.Name == oldNameClient).FirstOrDefault().Name = newNameClient;  
            }
            ctx.SaveChanges();
        }

    }
}
