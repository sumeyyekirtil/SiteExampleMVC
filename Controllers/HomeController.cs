using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SiteExampleMVC.Models;

//view lerde @* *@ arasýna yazýlan kod bloðu yorum satýrýdýr

namespace SiteExampleMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //go to view ile görünüm koduna gidiyoruz
        {
            return View();
        }
        //like it  kitap film dizi hobi
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Education()
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