using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.EntityLayer.Concrete
{
    public class Content: BaseEntity
    {
        public string ContentText { get; set; }
  

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }


        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
