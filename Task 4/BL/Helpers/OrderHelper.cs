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
            using (BaseContext ctx = new BaseContext())
            {
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

        public IList<Order> ConvertWievToOrder(IList<OrderWievModel> listOrderWM)
        {
            using (BaseContext ctx = new BaseContext())
            {
                ClientHelper clientHelper = new ClientHelper();
                List<Order> result = listOrderWM.Select(x => new Order()
                                                                {
                                                                    DateOrder = x.DateOrder,
                                                                    IdClient = clientHelper.GetIdClient(x.NameClient),
                                                                    Product = x.Product,
                                                                    Cost = x.CostProduct
                                                                }).ToList();
                return result;
            }
        }
    }
}
