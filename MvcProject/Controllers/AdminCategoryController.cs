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
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());

        [HttpGet]
        public ActionResult Index()
        {
            var categoryValues = cm.GetCategoryList();
            return View(categoryValues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category cat)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(cat);

            if (results.IsValid)
            {
                cm.CategoryAddBL(cat);
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