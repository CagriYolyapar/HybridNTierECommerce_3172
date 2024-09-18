using HybridNTierECommerce.ENTITIES.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus.DataSets;

namespace HybridNTierECommerce.DAL.BogusHandling
{
    public static class ProductDataSeed
    {
 
        public static void SeedProducts(ModelBuilder modelBuilder)
        {
            List<Product> products = new();

            for (int i = 1; i < 11; i++)
            {
                Product p = new()
                {
                    ID = i,
                    ProductName = new Commerce("tr").ProductName(),
                    Price = Convert.ToDecimal(new Commerce("tr").Price()),
                    UnitsInStock = 100,
                    CategoryID = i,
                    ImagePath = new Images().DataUri(100, 100)
                };

                products.Add(p);
            }

            modelBuilder.Entity<Product>().HasData(products);

        }
    }
}
