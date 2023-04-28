using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.EntityLayer.Concrete
{
    public class Message: BaseEntity
    {
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
    }
}
