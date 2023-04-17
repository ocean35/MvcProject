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
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList() 
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
        public ActionResult AddCategory(Category c)
        {
            //cm.CategoryAddBL(c);
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(c);

            if (results.IsValid)
            {
                cm.CategoryAddBL(c);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View(); // Ekleme işlemi gerçekleştikten sonra beni GetCategoryList metoduna yönlendir.
        }
    }
}