using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.ENTITIES.Models
{
    public abstract class BaseMoneySpec : BaseEntity
    {
        public decimal Price { get; set; }
    }
}
