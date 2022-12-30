using System.Collections.Generic;
using doustore.business.Abstract;
using doustore.data.Abstract;
using doustore.entity;

namespace doustore.business.Concrete
{
    public class OrderManager : IOrderService
    {
         private readonly IUnitOfWork _unitofwork;
        public OrderManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public void Create(Order entity)
        {
            _unitofwork.Orders.Create(entity);
            _unitofwork.Save();
        }

        public List<Order> GetOrders(string userId)
        {
            return  _unitofwork.Orders.GetOrders(userId);
        }
    }
}