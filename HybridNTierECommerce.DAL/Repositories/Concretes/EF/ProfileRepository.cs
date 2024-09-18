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
    public class ProfileRepository:BaseRepository<AppUserProfile>,IProfileRepository
    {
        public ProfileRepository(MyContext db):base(db)
        {

        }
    }
}
