using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Managers.Concretes
{
    public class CategoryManager : BaseManager<Category>, ICategoryManager
    {
        readonly ICategoryRepository _catRep;

        public CategoryManager(ICategoryRepository catRep):base(catRep)
        {
            _catRep = catRep;
        }

        public void Deneme()
        {
            throw new NotImplementedException();
        }
    }
}
