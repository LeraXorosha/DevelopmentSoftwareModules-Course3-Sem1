using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StringGeneratorService _stringGenerator;

        public HomeController(
            ILogger<HomeController> logger, 
            StringGeneratorService stringGenerator)
        {
            _logger = logger;
            _stringGenerator = stringGenerator;
        }

        public IActionResult Index()
        {
            

            var model = new IndexViewModel();
            model.Strings = _stringGenerator.Generate().ToList();
            return View(model);
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