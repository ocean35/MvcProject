using MvcProject.BusinessLayer.Concrete;
using MvcProject.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EFHeadingDal());

        public ActionResult Index()
        {
            var geadingValues = hm.GetHeadingList();
            return View(geadingValues);
        }
    }
}