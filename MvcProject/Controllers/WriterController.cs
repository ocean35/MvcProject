using MvcProject.BusinessLayer.Concrete;
using MvcProject.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterDal());
        public ActionResult Index()
        {
            var writerList = wm.GetWriterList();
            return View(writerList);
        }
    }
}