using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClientManager
    {
        public void AddClient(string clientName)
        {
            BaseContext ctx = new BaseContext();
            Client client = new Client() { Name = clientName };
            ctx.Clients.Add(client);
            ctx.SaveChanges();
        }

    }
}
