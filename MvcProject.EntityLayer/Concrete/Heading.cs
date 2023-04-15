using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.EntityLayer.Concrete
{
    public class Heading: BaseEntity
    {
        public string HeadingName { get; set; }


        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }


        public ICollection<Content> Contents { get; set; }

    }
}
