using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class OrderHelper
    {
        public void AddOrder(OrderWievModel orderWM)
        {
            BaseContext ctx = new BaseContext();
            ClientHelper clientHelper = new ClientHelper();
            Order order = new Order()
                                    {
                                        DateOrder = orderWM.DateOrder,
                                        IdClient = clientHelper.GetIdClient(orderWM.NameClient),
                                        Product = orderWM.Product,
                                        Cost = orderWM.CostProduct
                                    };
            ctx.Orders.Add(order);
            ctx.SaveChanges();
        }
    }
}
