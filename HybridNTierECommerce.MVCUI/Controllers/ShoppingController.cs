using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.ENTITIES.Models;
using HybridNTierECommerce.MVCUI.Models.PageVMs;
using HybridNTierECommerce.MVCUI.Models.SessionService;
using HybridNTierECommerce.MVCUI.Models.ShoppingTools;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using X.PagedList;

namespace HybridNTierECommerce.MVCUI.Controllers
{
    public class ShoppingController : Controller
    {
        readonly IProductManager _productManager;
        readonly ICategoryManager _categoryManager;
        readonly IOrderManager _orderManager;
        readonly IOrderDetailManager _orderDetailManager;
        readonly UserManager<AppUser>? _userManager;
        readonly IHttpClientFactory _httpClientFactory;

        public ShoppingController(IProductManager productManager, ICategoryManager categoryManager, IOrderManager orderManager, IOrderDetailManager orderDetailManager, UserManager<AppUser>? userManager, IHttpClientFactory httpClientFactory)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
            _orderManager = orderManager;
            _orderDetailManager = orderDetailManager;
            _userManager = userManager;
            _httpClientFactory = httpClientFactory;
        }



        public IActionResult Index(int? page,int? categoryID)
        {

            //string a = "Cagri";

            //string b = a ?? "Deneme"; eger a null ise "Deneme" string verisini null degilse  a'nın kendi degerini b'ye at demektir...
            ShoppingPageVM spVm = new()
            {
                Products = categoryID == null ? _productManager.GetActives().ToPagedList(page??1,5) : _productManager.Where(x=>x.CategoryID == categoryID).ToPagedList(page??1,5),
                Categories = _categoryManager.GetActives()
            };

            if (categoryID != null) TempData["catID"] = categoryID;

            return View(spVm);
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            Cart c = GetCartFromSession("scart") == null ? new Cart() : GetCartFromSession("scart");
            Product productToBeAdded = await _productManager.FindAsync(id);
            CartItem ci = new()
            {
                ID = productToBeAdded.ID,
                ProductName = productToBeAdded.ProductName,
                UnitPrice = productToBeAdded.Price,
                ImagePath = productToBeAdded.ImagePath,
                CategoryID = productToBeAdded.CategoryID,
                CategoryName = productToBeAdded.Category.CategoryName
            };

            c.AddToCart(ci);

            SetCartForSession(c);

            TempData["Message"] = $"{ci.ProductName} isimli ürün sepete eklenmiştir";
            return RedirectToAction("Index");
        }

        #region PrivateCartHandlingMethods
        void SetCartForSession(Cart c)
        {
            HttpContext.Session.SetObject("scart", c);
        }

        Cart GetCartFromSession(string key)
        {
            return HttpContext.Session.GetObject<Cart>(key);
        } 

        void ControlCart(Cart c)
        {
            if (c.GetCartItems.Count == 0) HttpContext.Session.Remove("scart");
        }
        #endregion

        public IActionResult CartPage()
        {
            if(GetCartFromSession("scart") == null)
            {
                TempData["Message"] = "Sepetiniz su anda bos";
                return RedirectToAction("Index");
            }
            Cart c = GetCartFromSession("scart");
            return View(c);
        }


        public IActionResult DeleteFromCart(int id)
        {
            if(GetCartFromSession("scart") != null)
            {
                Cart c = GetCartFromSession("scart");
                c.RemoveFromCart(id);
                SetCartForSession(c);
                ControlCart(c);

            }
            return RedirectToAction("CartPage");
        }

        public IActionResult DecreaseFromCart(int id)
        {
            if(GetCartFromSession("scart") != null)
            {
                Cart c = GetCartFromSession("scart");
                c.Decrease(id);
                SetCartForSession(c);
                ControlCart(c);
            }

            return RedirectToAction("CartPage");
        }


        public IActionResult ConfirmOrder()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmOrder(OrderRequestPageVM ovm)
        {
            Cart c = GetCartFromSession("scart");
            ovm.Order.Price = ovm.PaymentRequestModel.ShoppingPrice = c.TotalPrice;

            //http://localhost:5268
            //API entegrasyonu 


            //API'yi consume etmek icin middleware'de ilk basta bir ayarlama yapmak zorundasınız...

            #region APIIntegration

            HttpClient client = _httpClientFactory.CreateClient();
            string jsonData = JsonConvert.SerializeObject(ovm.PaymentRequestModel);

            //Content : icerik

            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:5268/api/Transaction", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                if (User.Identity.IsAuthenticated)
                {
                    AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                    ovm.Order.AppUserID = appUser.Id;

                }

                await _orderManager.AddAsync(ovm.Order); //Önce Order'in ID'sinin olusması lazım..BUrada Order'i kaydederek Id'nin Identity sayesinde olusmasını saglıyoruz...


                foreach (CartItem item in c.GetCartItems)
                {
                    OrderDetail od = new();
                    od.OrderID = ovm.Order.ID;
                    od.ProductID = item.ID;
                    od.Quantity = item.Amount;
                    od.Price = item.UnitPrice;
                    await _orderDetailManager.AddAsync(od);

                    //ürün stoktan düsmeli
                }

                TempData["Message"] = "Siparişiniz bize basarıyla ulasmıstır...Tesekkür ederiz...";
                return RedirectToAction("Index");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();
            TempData["Message"] =result;
            return RedirectToAction("Index");

            #endregion




          
        }

    }

   
}
