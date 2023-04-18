using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.DataAccessLayer.Abstract
{
    public interface IRepository<T> 
    {
        List<T> List();
        void Insert(T category);
        T Get(Expression<Func<T, bool>> filter);
        void Update(T category);
        void Delete(T category);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
