using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class SlidePortFolio : ViewComponent
    {
        PortFolioManager portFolioManager = new PortFolioManager(new EfPortFolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portFolioManager.TGetList();
            return View(values);
        }
    }
}
