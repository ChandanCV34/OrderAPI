using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Services
{
    public class OrderService
    {
        private readonly OrderContext _orderContext;

        public OrderService(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }

        public ICollection<Order> Get()
        {
            IList<Order> order = _orderContext.orders.ToList();
            return order;
        }
    }
}
