using Jennifer.BeautySalon.Domain.Abstract;
using Jennifer.BeautySalon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jennifer.BeautySalon.Domain.Concrete
{
    public class EFBeautyProductRepository : IBeautyProductsRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<BeautyProduct> BeautyProducts
        {
            get { return context.BeautyProducts; }
        }

    }
}
