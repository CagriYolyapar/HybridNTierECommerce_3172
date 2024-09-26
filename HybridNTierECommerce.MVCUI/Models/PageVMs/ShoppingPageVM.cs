using HybridNTierECommerce.ENTITIES.Models;
using X.PagedList;

namespace HybridNTierECommerce.MVCUI.Models.PageVMs
{
    //Todo:Refactor 
    public class ShoppingPageVM
    {
        public List<Category> Categories { get; set; }
        public IPagedList<Product> Products { get; set; } //Burada List yerine IPagedList dememizin sebebi göndermek istedigimiz Product listesinin sayfalanabilir bir koleksiyon halinde gönderilmesini istememizdir...
    }
}
