using Jennifer.BeautySalon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jennifer.BeautySalon.Domain.Concrete
{
    public class EFDbContext : DbContext
   {
        public DbSet<BeautyProduct> BeautyProducts { get; set; }
    }
}
