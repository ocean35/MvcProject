using FluentValidation.Results;
using MvcProject.BusinessLayer.Concrete;
using MvcProject.BusinessLayer.ValidationRules;
using MvcProject.DataAccessLayer.EntityFramework;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());

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

        public ActionResult DeleteCategory(int id)
        {
            var categoryValue = cm.GetByID(id);
            cm.CategoryDelete(categoryValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryValue = cm.GetByID(id);
            return View(categoryValue);
        }

        [HttpPost]
        public ActionResult EditCategory(Category category)
        {
           cm.CategoryUpdate(category);
            return RedirectToAction("Index");
        }
    }
}