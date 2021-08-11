using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Interfaces.Facade
{
    public interface IOrderService
    {

        Task<List<Order.Domain.Entities.Order>> GetAllOrders();
        Task<Guid> Add(Order.Domain.Entities.Order order);
        Task<List<Order.Domain.Entities.Order>> GetByUser(string user);
        Task<List<Order.Domain.Entities.Order>> GetOrder(Guid id);
        Task UpdateOrder(Order.Domain.Entities.Order order);


    }
}
