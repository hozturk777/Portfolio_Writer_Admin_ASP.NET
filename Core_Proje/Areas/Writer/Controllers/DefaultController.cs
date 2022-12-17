using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]  //Hangi Area'da Çalıştığını Belirttik
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
