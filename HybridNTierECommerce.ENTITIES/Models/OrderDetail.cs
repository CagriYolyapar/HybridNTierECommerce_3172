using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.ENTITIES.Models
{
    public class OrderDetail : BaseMoneySpec
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        //public decimal UnitPrice { get; set; }


        //Relational Properties
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

    }
}
