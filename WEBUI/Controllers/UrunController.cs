using BLL;
using Microsoft.AspNetCore.Mvc;

namespace WEBUI.Controllers
{
    public class UrunController : Controller
    {
        private readonly UrunServis urunServis;

        public UrunController()
        {
            urunServis = new UrunServis();
        }
        public IActionResult Index()
        {
            var urunler = urunServis.GetAll();
            return View(urunler);
        }
    }
}
