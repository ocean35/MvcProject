using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetWriterList();
        void WriterAddBL(Writer writer);
        Writer GetByID(int id);
        void WriterDelete(Writer writer);
        void WriterUpdate(Writer writer);
    }
}
