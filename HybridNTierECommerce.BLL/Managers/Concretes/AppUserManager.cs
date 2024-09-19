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
    public class AppUserManager : BaseManager<AppUser>, IAppUserManager
    {
        readonly IAppUserRepository _appRep;
        public AppUserManager(IAppUserRepository appRep):base(appRep)
        {
            _appRep  = appRep;
        }

      
    }
}
