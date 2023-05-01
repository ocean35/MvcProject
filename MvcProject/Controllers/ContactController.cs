using MvcProject.BusinessLayer.Concrete;
using MvcProject.BusinessLayer.ValidationRules;
using MvcProject.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactDal());
        ContactValidator cv = new ContactValidator();
        // GET: Contact
        public ActionResult Index()
        {
            var contactValues = cm.GetContactList();
            string m = cm.GetContactList().Count().ToString();
            ViewBag.clc = m;
            return View(contactValues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactValues = cm.GetByID(id);
            return View(contactValues);
        }

        //[HttpGet]
        //public ActionResult ContactListCount()
        //{
        //    ViewBag.clc = cm.GetContactList().Count().ToString();
        //    return View();
        //}

        public PartialViewResult ContactPartialFoldersAndLabels()
        {
            return PartialView();
        }
    }
}