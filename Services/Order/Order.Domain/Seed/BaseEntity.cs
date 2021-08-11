using Order.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Entities.Seed
{
    public abstract class BaseEntity<T> where T: BaseAuditModel
    {

        public Guid Id { get; protected set; }

        public bool IsActive { get; protected set; }

        public DateTime CreatedDate { get; protected set; }

        public abstract T MapToModel();
        public abstract T MapToModel(T t);

    }
}
