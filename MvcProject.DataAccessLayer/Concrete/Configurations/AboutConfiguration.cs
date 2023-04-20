using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.DataAccessLayer.Concrete.Configurations
{
    public class AboutConfiguration: EntityTypeConfiguration<About>
    {
        public AboutConfiguration()
        {
            this.Property(p => p.AboutDetailsFirst).HasMaxLength(1000);
            this.Property(p => p.AboutDetailsSecond).HasMaxLength(1000);
            this.Property(p => p.AboutImageFirst).HasMaxLength(100);
            this.Property(p => p.AboutImageSecond).HasMaxLength(100);
        }
    }
}
