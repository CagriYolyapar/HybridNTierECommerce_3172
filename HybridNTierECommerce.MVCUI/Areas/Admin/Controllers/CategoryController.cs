using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.ENTITIES.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HybridNTierECommerce.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class CategoryController : Controller
    {
        //CategoryManager - CategoryRepository

        //BaseManager    - BaseRepository

        //Önemli : Tüm Refactor'lerde(Domain Entity iceren tüm Refactorlerde) Refactoring'i su yasam döngüsüne göre yapın : VM(PageVM/PureVM vs) Validation sistemini yaratın => DTO'yu yapın => Manager'i Agile


        readonly ICategoryManager _catManager;

        public CategoryController(ICategoryManager catManager)
        {
            _catManager = catManager;
        }
        public IActionResult Index()
        {
            return View(_catManager.GetAll());
            
         
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Category model)
        {
           TempData["Message"]  = await _catManager.AddAsync(model);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteCategory(int id)
        {
            _catManager.Delete(await _catManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DestroyCategory(int id)
        {
            TempData["Message"] = _catManager.Destroy(await _catManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateCategory(int id)
        {
            return View(await _catManager.FindAsync(id));
        }


        [HttpPost]
        public async Task<IActionResult> UpdateCategory(Category model)
        {
            await _catManager.UpdateAsync(model);
            return RedirectToAction("Index");
        }


       
    }
}
