using MvcProject.BusinessLayer.Abstract;
using MvcProject.DataAccessLayer.Abstract;
using MvcProject.DataAccessLayer.EntityFramework;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        private readonly IHeadingDal _headingDal;
        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }
        public Heading GetByID(int id)
        {
            return _headingDal.Get(x => x.ID == id);
        }

        public List<Heading> GetHeadingList()
        {
            return _headingDal.List();
        }

        public void HeadingAddBL(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void HeadingDelete(Heading heading)
        {
            _headingDal.Delete(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
