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
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MyContext db):base(db)
        {

        }
    }
}
