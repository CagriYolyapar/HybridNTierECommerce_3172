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
    public static class CategoryDataSeed
    {
        public static void SeedCategories(ModelBuilder modelBuilder)
        {
            List<Category> categories = new();

            for (int i = 1; i < 11; i++)
            {
                Category c = new()
                {
                    ID = i,
                    CategoryName = new Commerce("tr").Categories(1)[0],
                    Description = new Lorem("tr").Sentence(10)

                };

                categories.Add(c);
            }

            modelBuilder.Entity<Category>().HasData(categories);



        }
    }
}
