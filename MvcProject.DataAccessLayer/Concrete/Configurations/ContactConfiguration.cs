using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.DataAccessLayer.Concrete.Configurations
{
    public class ContactConfiguration: EntityTypeConfiguration<Contact>
    {
        public ContactConfiguration()
        {
            this.Property(p=>p.UserName).HasMaxLength(50);
            this.Property(p=>p.UserMail).HasMaxLength(100);
            this.Property(p=>p.Subject).HasMaxLength(50);
            this.Property(p=>p.Message).HasMaxLength(1000);
        }
    }
}
