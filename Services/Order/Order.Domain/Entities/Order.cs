using Order.Domain.Entities.Seed;
using Order.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Entities
{
    public class Order : BaseEntity <OrderModel>
    {
        public decimal TotalPrice { get; set; }
        public string UserName { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        public override OrderModel MapToModel()
        {
            throw new NotImplementedException();
        }

        public override OrderModel MapToModel(OrderModel t)
        {
            throw new NotImplementedException();
        }
    }
}
