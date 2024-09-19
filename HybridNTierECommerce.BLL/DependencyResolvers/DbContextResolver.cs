using HybridNTierECommerce.DAL.ContextClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.DependencyResolvers
{
    //DbContextPool'umuz burada bir Extension metot sayesinde inject edilecek
    public static class DbContextResolver
    {

        //Neden ServiceProvider

        //Cünkü biz bu noktada aslında Core.MVC platformundaki startup dosyasında degiliz...Dolayısıyla oradaki hazır service yapısımı elimizde yok..Biz o yapıları ayaga kaldırmak adına bir giriş noktasına ihtiyac duyarız...Ve bu giriş noktasına bana ServiceProvider nesnesi saglar


        public static void AddDbContextService(this IServiceCollection services)
        {
            ServiceProvider provider = services.BuildServiceProvider();

            //Sakın IConfiguration kullanırken Castle kütüphanesini kullanmayın. Kullanacagınız kütüphane Microsoft.Extensions.Configuration.Abstractions olmak zorundadır...

            //Neden IConfiguration

            //IConfiguration sayesinde projenizin UI tarafının conf(ayarlamalarını) bulundugu dosyaya ulasabiliyorsunuz

            IConfiguration? configuration = provider.GetService<IConfiguration>();

            services.AddDbContextPool<MyContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies());

            
        }
    }
}
