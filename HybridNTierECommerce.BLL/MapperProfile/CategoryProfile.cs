using AutoMapper;
using HybridNTierECommerce.BLL.DTOClasses;
using HybridNTierECommerce.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.MapperProfile
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDTO>().ForMember(target => target.Aciklama, org => org.MapFrom(x => x.Description)).ReverseMap();
        }
    }
}
