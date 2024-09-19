using HybridNTierECommerce.DAL.ContextClasses;
using HybridNTierECommerce.ENTITIES.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.DependencyResolvers
{
    public static class CustomIdentityResolver
    {
        public static void AddIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole<int>>(x =>
            {
                x.Password.RequireDigit = false;
                x.Password.RequiredLength = 3;
                x.Password.RequireUppercase = false;
                x.Password.RequireLowercase = false;
                x.SignIn.RequireConfirmedEmail = true;
                x.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<MyContext>();
        }
    }
}
