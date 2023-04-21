using FluentValidation.Results;
using MvcProject.BusinessLayer.Concrete;
using MvcProject.BusinessLayer.ValidationRules;
using MvcProject.DataAccessLayer.EntityFramework;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class WriterController : Controller
    {
        WriterValidator writerValidator = new WriterValidator();
        WriterManager wm = new WriterManager(new EFWriterDal());

        public ActionResult Index()
        {
            var writerList = wm.GetWriterList();
            return View(writerList);
        }

        [HttpGet]
        public ActionResult AddWriter() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddWriter(Writer writer)
        {
            ValidationResult results = writerValidator.Validate(writer);

            if (results.IsValid)
            {
                wm.WriterAddBL(writer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var writerValue = wm.GetByID(id);
            return View(writerValue);
        }

        [HttpPost]
        public ActionResult EditWriter(Writer writer)
        {
            ValidationResult results = writerValidator.Validate(writer);
            var writerValue = wm.GetByID(writer.ID);
           
            if (results.IsValid)
            {
                writerValue.WriterName = writer.WriterName;
                writerValue.WriterSurname = writer.WriterSurname;
                writerValue.WriterEmail = writer.WriterEmail;
                writerValue.WriterPassword = writer.WriterPassword;
                writerValue.WriterImage = writer.WriterImage;
                writerValue.WriterAbout = writer.WriterAbout;
                writerValue.WriterTitle= writer.WriterTitle;

                wm.WriterUpdate(writerValue);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}