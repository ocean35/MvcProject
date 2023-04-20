using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.DataAccessLayer.Concrete.Configurations
{
    public class ContentConfiguration: EntityTypeConfiguration<Content>
    {
        public ContentConfiguration()
        {
            this.Property(p=>p.ContentText).HasMaxLength(1000);
        }
    }
}
