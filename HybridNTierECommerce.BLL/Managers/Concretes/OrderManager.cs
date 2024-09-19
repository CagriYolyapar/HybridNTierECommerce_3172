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
    public class OrderManager:BaseManager<Order>, IOrderManager
    {
        readonly IOrderRepository _oRep;

        public OrderManager(IOrderRepository oRep):base(oRep)
        {
            _oRep = oRep;
        }
    }
}
