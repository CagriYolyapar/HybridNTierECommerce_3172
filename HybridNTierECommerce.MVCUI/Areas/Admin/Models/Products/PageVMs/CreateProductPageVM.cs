using HybridNTierECommerce.ENTITIES.Models;

namespace HybridNTierECommerce.MVCUI.Areas.Admin.Models.Products.PageVMs
{
    public class CreateProductPageVM
    {
        //Refactor Domain Entity'leri düzenleyiniz
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}
