using Order.Domain.Entities.Seed;
using Order.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Entities
{
    public class OrderItem: BaseEntity<OrderItemModel>
    {
        public decimal Qty { get; protected set; }
        public string Name { get; protected set; }

        public decimal Price { get; protected set; }

        public override OrderItemModel MapToModel()
        {
            throw new NotImplementedException();
        }

        public override OrderItemModel MapToModel(OrderItemModel t)
        {
            throw new NotImplementedException();
        }
    }
}
