using HybridNTierECommerce.ENTITIES.Interfaces;
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
    public abstract class BasePriceConfiguration<T> : BaseConfiguration<T> where T:BaseMoneySpec
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Price).HasColumnType("money");
        }
    }
}
