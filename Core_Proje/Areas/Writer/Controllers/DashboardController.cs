using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]

    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;

            //Weather APİ
            string connection = "http://api.weatherapi.com/v1/current.xml?key= b1c6013f547044edb0e201043222812&q=Afyonkarahisar&aqi=no";
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temp_c").ElementAt(0).Value;
            ViewBag.v6 = document.Descendants("name").ElementAt(0).Value;
            ViewBag.v7 = document.Descendants("country").ElementAt(0).Value;



            //Statistics
            Context c = new Context();
            ViewBag.v1 = c.WriterMessages.Where(x =>x.Receiver == values.Email).Count();
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.Users.Count();
            ViewBag.v4 = c.Skills.Count();
            return View();
        }
    }
}
/*http://api.weatherapi.com/v1/current.xml?key= b1c6013f547044edb0e201043222812&q=Afyonkarahisar&aqi=no*/