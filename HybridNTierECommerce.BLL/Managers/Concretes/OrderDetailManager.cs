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
    public class OrderDetailManager:BaseManager<OrderDetail>, IOrderDetailManager
    {
        readonly IOrderDetailRepository _odRep;

        public OrderDetailManager(IOrderDetailRepository odRep):base(odRep) 
        {
            _odRep = odRep;
        }
    }
}
