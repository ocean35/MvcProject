using MvcProject.BusinessLayer.Abstract;
using MvcProject.DataAccessLayer.Abstract;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        private IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal= writerDal;
        }


        public Writer GetByID(int id)
        {
            return _writerDal.Get(x => x.ID == id);
        }

        public List<Writer> GetWriterList()
        {
            return _writerDal.List();
        }

        public void WriterAddBL(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
