using HybridNTierECommerce.DAL.ContextClasses;
using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.DAL.Repositories.Concretes.EF
{

    //IProductRepository _proRep;

    /*
     
     public HomeController(IProductRepository proRep)
    {
    }
     
     
     
     */

    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(MyContext db):base(db)
        {

        }
    }
}
