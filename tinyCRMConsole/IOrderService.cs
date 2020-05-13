using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyCrmConsole
{
    public interface IOrderService
    {
        Order CreateOrder(OrderCreateOptions options);
        IQueryable <Order> SearchOrder(OrderSearchOptions options);
        Order UpdateOrder(OrderUpdateOptions options, int? ordId);
        Order GetOrderById(int? ordId);
    }
}
