using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.EntityLayer.Concrete
{
    public class Writer: BaseEntity
    {
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterImage { get; set; }
        public string WriterEmail { get; set; }
        public string WriterPassword { get; set;}
    }
}
