using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.EntityLayer.Concrete
{
    public class Contact: BaseEntity
    {
        public string UserName { get; set; }

        public string UserMail { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }
}
