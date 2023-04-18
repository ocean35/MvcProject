using MvcProject.BusinessLayer.Abstract;
using MvcProject.DataAccessLayer.Abstract;
using MvcProject.DataAccessLayer.Concrete.Repositories;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAddBL(Category category)
        {
            _categoryDal.Insert(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x=> x.ID == id);   
        }

        public List<Category> GetCategoryList()
        {
            return _categoryDal.List();
        }
    }
}
