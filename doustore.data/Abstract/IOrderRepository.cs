using System.Collections.Generic;
using doustore.entity;

namespace doustore.data.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetOrders(string userId);
    }
}