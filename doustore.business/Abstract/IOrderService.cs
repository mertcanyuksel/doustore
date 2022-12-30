using System.Collections.Generic;
using doustore.entity;

namespace doustore.business.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
        List<Order> GetOrders(string userId);
    }
}