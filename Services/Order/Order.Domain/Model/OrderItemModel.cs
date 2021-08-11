using Order.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Model
{
    public class OrderItemModel : BaseAuditModel
    {
        public decimal Qty { get; protected set; }
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }

    }
}
