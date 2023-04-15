using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.EntityLayer.Concrete
{
    public class About: BaseEntity
    {
        public string AboutDetailsFirst { get; set; }
        public string AboutDetailsSecond { get; set; }
        public string AboutImageFirst { get; set; }
        public string AboutImageSecond { get; set; }

    }
}
