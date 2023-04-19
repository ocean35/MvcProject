using MvcProject.BusinessLayer.Concrete;
using MvcProject.DataAccessLayer.EntityFramework;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class StatisticsController : Controller
    {

        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        HeadingManager hm = new HeadingManager(new EFHeadingDal());
        WriterManager wm = new WriterManager(new EFWriterDal());


        public  ActionResult Index()
        {
            //Toplam Kategori Sayısı
            ViewBag.CategoryCount = cm.GetCategoryList().Select(x => x.CategoryName).Distinct().Count();

            //Başlık tablosunda "yazılım" kategorisine ait başlık sayısı
            var getCatid = cm.GetCategoryList().Where(x => x.CategoryName == "Yazilim").SingleOrDefault();
            ViewBag.HeadingCountWithYazilimCategory = hm.GetHeadingList().Where(x => x.CategoryID == getCatid.ID).Count();

            //Yazar adında 'a' harfi geçen yazar sayısı
            ViewBag.WriterCountWithLetterA = wm.GetWriterList().Where(x => x.WriterName.Contains("a") ||  x.WriterName.Contains("A")).Count();

            //En fazla başlığa sahip kategori adı
            var headingList = hm.GetHeadingList().GroupBy(x => x.CategoryID).Take(1);
            ViewBag.MaxCategoryName = cm.GetCategoryList().Where(x => x.ID == headingList.First().Key).First().CategoryName;

            //Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark
            ViewBag.CategoryDifference = cm.GetCategoryList().Where(x => x.CategoryStatus == true).Count() - cm.GetCategoryList().Where(x => x.CategoryStatus == false).Count();
           

            return View();
        }
    }
}