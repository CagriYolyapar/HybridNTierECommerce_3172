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
    public class ProfileManager:BaseManager<AppUserProfile>,IProfileManager
    {
        readonly IProfileRepository _proRep;
        public ProfileManager(IProfileRepository proRep):base(proRep)
        {
            _proRep = proRep;
        }
    }
}
