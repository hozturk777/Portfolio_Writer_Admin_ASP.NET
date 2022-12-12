using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortFolioManager : IPortFolioService
    {
        IPortFolioDal _portFolioDal;

        public PortFolioManager(IPortFolioDal portFolioDal)
        {
            _portFolioDal = portFolioDal;
        }

        public void TAdd(PortFolio t)
        {
            _portFolioDal.Insert(t);
        }

        public void TDelete(PortFolio t)
        {
            _portFolioDal.Delete(t);
        }

        public PortFolio TGetByID(int id)
        {
            return _portFolioDal.GetByID(id);
        }

        public List<PortFolio> TGetList()
        {
            return _portFolioDal.GetList();
        }

        public void TUpdate(PortFolio t)
        {
            _portFolioDal.Update(t);
        }
    }
}
