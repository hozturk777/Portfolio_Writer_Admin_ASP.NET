using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class ProjectList : ViewComponent
    {
        PortFolioManager portFolio = new PortFolioManager(new EfPortFolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portFolio.TGetList();
            return View(values);
        }
    }
}
