using Newtonsoft.Json;

namespace HybridNTierECommerce.MVCUI.Models.ShoppingTools
{
    [Serializable]
    public class CartItem
    {
        public CartItem()
        {
            Amount++;
        }

        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        [JsonProperty("Amount")]
        public int Amount { get; set; }

        [JsonProperty("UnitPrice")]
        public decimal UnitPrice { get; set; }

        [JsonProperty("SubTotal")]
        public decimal SubTotal { get { return Amount * UnitPrice; } }

        [JsonProperty("ImagePath")]
        public string ImagePath { get; set; }

        [JsonProperty("CategoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("CategoryID")]
        public int? CategoryID { get; set; }
    }
}
