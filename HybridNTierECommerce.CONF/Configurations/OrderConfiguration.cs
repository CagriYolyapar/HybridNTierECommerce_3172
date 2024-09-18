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
    public class OrderConfiguration:BasePriceConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
         
        }
    }
}
