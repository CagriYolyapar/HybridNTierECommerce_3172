using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.ENTITIES.Models
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual ICollection<Product> Products { get; set; }

    }
}
