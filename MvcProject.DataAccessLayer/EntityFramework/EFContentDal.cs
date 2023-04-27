using MvcProject.DataAccessLayer.Abstract;
using MvcProject.DataAccessLayer.Concrete.Repositories;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.DataAccessLayer.EntityFramework
{
    public class EFContentDal: GenericRepository<Content>, IContentDal
    {
    }
}
