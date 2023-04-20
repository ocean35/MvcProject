using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.DataAccessLayer.Concrete.Configurations
{
    public class CategoryConfiguration: EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            this.Property(p => p.CategoryName).HasMaxLength(50);
            this.Property(p => p.CategoryDescription).HasMaxLength(200);
        }
    }
}
