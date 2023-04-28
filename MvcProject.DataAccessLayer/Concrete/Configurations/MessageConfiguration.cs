using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.DataAccessLayer.Concrete.Configurations
{
    public class MessageConfiguration: EntityTypeConfiguration<Message>
    {
        public MessageConfiguration()
        {
            this.Property(p => p.SenderMail).HasMaxLength(50);
            this.Property(p => p.ReceiverMail).HasMaxLength(50);
            this.Property(p => p.Subject).HasMaxLength(100);
        }
    }
}
