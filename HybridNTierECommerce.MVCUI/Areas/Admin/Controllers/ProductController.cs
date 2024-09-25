using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.ENTITIES.Models;
using HybridNTierECommerce.MVCUI.Areas.Admin.Models.Products.PageVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HybridNTierECommerce.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class ProductController : Controller
    {
        readonly IProductManager _productManager;
        readonly ICategoryManager _categoryManager;

        public ProductController(IProductManager productManager, ICategoryManager categoryManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
        }

        public IActionResult Index()
        {
            return View(_productManager.GetAll());
        }


        public IActionResult Create()
        {
            CreateProductPageVM cpVM = new()
            {
                Categories = _categoryManager.GetActives()
            };
            return View(cpVM);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductPageVM productVm,IFormFile formFile)
        {
            Product p = productVm.Product;

            #region ResimKodlari
            Guid uniqueName = Guid.NewGuid();
            string extension = Path.GetExtension(formFile.FileName); //dosyanın uzantısını ele gecirdik
            p.ImagePath = $"/images/{uniqueName}{extension}";

            string path = $"{Directory.GetCurrentDirectory()}/wwwroot{p.ImagePath}";
            FileStream stream = new(path, FileMode.Create);
            formFile.CopyTo(stream);





            #endregion
            _productManager.Add(p);
            return RedirectToAction("Index");
        }
    }
}
