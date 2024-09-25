using Newtonsoft.Json;

namespace HybridNTierECommerce.MVCUI.Models.ShoppingTools
{
    [Serializable]
    public class Cart
    {
        [JsonProperty("_myCart")]
        readonly Dictionary<int, CartItem> _myCart;

        public Cart()
        {
            _myCart = new Dictionary<int, CartItem>();

            //_myCart[1] normal şartlarda index parantezleri ilgili index'teki elemanı secme ifadesini söyler...Fakat bir Dictionary koleksiyonu söz konusu oldugunda bu index parantezi ilgili key'e sahip anahtarı sec demektir...
        }

        [JsonProperty("GetCartItems")]
        public List<CartItem> GetCartItems
        {
            get
            {
                return _myCart.Values.ToList();
            }
        }

        public void AddToCart(CartItem item)
        {
            if (_myCart.ContainsKey(item.ID))
            {
                _myCart[item.ID].Amount++;
                return;
            }
            _myCart.Add(item.ID,item);
        }

        public void Decrease(int id)
        {
            _myCart[id].Amount--;
            if (_myCart[id].Amount == 0) _myCart.Remove(id); //Dictionary'deki remove metodu, verdiginiz anahtardaki veriyi siler...
        }

        public void RemoveFromCart(int id)
        {
            _myCart.Remove(id);
        }


        //Odev: Adedini Update


        [JsonProperty("TotalPrice")]
        public decimal TotalPrice
        {
            get
            {
                return _myCart.Values.Sum(x => x.SubTotal);
            }
        }



    }
}
