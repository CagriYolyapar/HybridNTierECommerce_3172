using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.BLL.Managers.Concretes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.DependencyResolvers
{
    public static class ManagerResolver
    {
        public static void AddManagerServices(this IServiceCollection services)
        {
            //services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));

            services.AddScoped<IProductManager,ProductManager>();
            services.AddScoped<ICategoryManager,CategoryManager>();
            services.AddScoped<IOrderDetailManager,OrderDetailManager>();
            services.AddScoped<IOrderManager,OrderManager>();
            services.AddScoped<IProfileManager,ProfileManager>();
            services.AddScoped<IAppUserManager,AppUserManager>();   
        }
    }
}
