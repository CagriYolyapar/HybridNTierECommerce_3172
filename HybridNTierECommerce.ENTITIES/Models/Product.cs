using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.ENTITIES.Models
{
    public class Product: BaseMoneySpec
    {
        public string ProductName { get; set; }
        //public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string ImagePath { get; set; }
        public int? CategoryID { get; set; }



        //Relational Properties
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
