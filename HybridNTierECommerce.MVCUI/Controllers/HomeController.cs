using HybridNTierECommerce.MVCUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HybridNTierECommerce.MVCUI.Controllers
{
    public class HomeController : Controller
    {


        //ICategoryRepository _catRep;

        //IOC (Inversion of Controls)


        //ICategoryRepository => CategoryRepository,CategorySpecRepository,CategoryV2Repository


        /*
         
         public HomeController(ICategoryRepository categoryRepository)

        {
           _catRep = categoryRepository;
        }
         


        //Middleware

        builder.Services.AddTransient(ICategoryRepository,CategoryRepository);
         
         
         
         */


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



      
    }
}
