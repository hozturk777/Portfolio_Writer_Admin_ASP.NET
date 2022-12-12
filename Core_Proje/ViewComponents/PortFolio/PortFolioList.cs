using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.PortFolio
{
    public class PortFolioList : ViewComponent
    {
        PortFolioManager folioManager = new PortFolioManager(new EfPortFolioDal());
        public IViewComponentResult Invoke()
        {
            var values = folioManager.TGetList();
            return View(values);
        }
    }
}
