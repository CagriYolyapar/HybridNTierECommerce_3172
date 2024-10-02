using AutoMapper;
using HybridNTierECommerce.BLL.MapperProfile;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.DependencyResolvers
{
    public static class MapperResolver
    {
        public static void AddMapperService(this IServiceCollection services)
        {


            // x => new {}

            // x => new Deneme {  Categoryname = x.CategoryName, Description = x.Description   }

            // _db.Category.Where(x => )


            MapperConfiguration mapConfiguration = new MapperConfiguration(x =>
            {
                x.AddProfile(new CategoryProfile());
            });

            IMapper mapper = mapConfiguration.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
