using HybridNTierECommerce.ENTITIES.Models;
using HybridNTierECommerce.MVCUI.Models.PaymentAPITools;

namespace HybridNTierECommerce.MVCUI.Models.PageVMs
{
    public class OrderRequestPageVM
    {
        public Order Order { get; set; }

        public PaymentRequestModel PaymentRequestModel { get; set; }
    }
}
