using HybridNTierECommerce.ENTITIES.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.CONF.Configurations
{
    public class OrderDetailConfiguration:BasePriceConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });
            
        }
    }
}
