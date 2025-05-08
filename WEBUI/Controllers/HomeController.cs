using BLL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WEBUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly UrunServis urunServis;

        public HomeController()
        {
            urunServis = new UrunServis();
        }
        public IActionResult Index()
        {
            var urunler = urunServis.GetAll();
            return View(urunler);
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        

    }
}
