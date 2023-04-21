using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.DataAccessLayer.Concrete.Configurations
{
    public class WriterConfiguration:EntityTypeConfiguration<Writer>
    {
        public WriterConfiguration()
        {
            this.Property(x => x.WriterName).HasMaxLength(50);
            this.Property(x => x.WriterSurname).HasMaxLength(50);
            this.Property(x => x.WriterImage).HasMaxLength(100);
            this.Property(x => x.WriterAbout).HasMaxLength(100);
            this.Property(x => x.WriterEmail).HasMaxLength(200);
            this.Property(x => x.WriterPassword).HasMaxLength(200);
            this.Property(x => x.WriterTitle).HasMaxLength(50);
        }
    }
}
