using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.DAL.Repositories.Concretes.EF;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.DependencyResolvers
{
    public static class RepositoryResolver
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            /*
             
             Transient Services : Bir request'in ulastıgı Scope'un parametre kümesinde aynı tipten kac tane varsa o kadar instance alınır...Manager ve Repository'ler icin anlamsızdır...Cünkü bunlardan bir tanesi bir Request'teki scope icin yeterlidir..


             public IActionResult Index(ICategoryManager catMan)
            {
            return View(); //Bu noktada döndürülen View da kendi icerisinde ICategoryManager tipi kullanıyorsa Transient sistemi burada onun icin de ayrı bir instance alınmasını saglar...
            }

            Scoped Services : Bir Request'te Scope'un parametre kümesinde veya ilgilendigi yapılarda aynı tipte birden fazla  yapı olsa bile 1 instance üzerinden calısırsınız...Ancak bu Singleton degildir...Cünkü Request'in işi bittigi zaman garbage collector Ram'den o instance'i kaldırır...Bir Request'in scope'unda aynı tipte birden fazla repository veya manager instance'i   gerekli degildir...Performansı düsürdügünden dolayı saglıklı görülmez...Scoped tercih edilir...

            Singleton Services: Bir request'in ulastıgı Scope'ta parametre kümesinde veya ilgili alanda bir tip görüldügü anda bir instance alınır ve program kapatılıncaya kadar o instance'dan devam edilir... Manager ve Repository'ler icin cok tehlikelidir
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             
             */


            //services.AddScoped(typeof(IRepository<>),typeof(BaseRepository<>));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IProfileRepository, ProfileRepository>();

            
        }
    }
}



