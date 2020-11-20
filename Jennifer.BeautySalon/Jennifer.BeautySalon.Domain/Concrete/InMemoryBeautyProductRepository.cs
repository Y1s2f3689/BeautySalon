using Jennifer.BeautySalon.Domain.Abstract;
using Jennifer.BeautySalon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jennifer.BeautySalon.Domain.Concrete
{
    public class InMemoryBeautyProductRepository : IBeautyProductsRepository
    {
        private List<BeautyProduct> _Beautyproducts = new List<BeautyProduct>
        {
        new BeautyProduct { Name = "EyebrowBrush", Price = 25 },
        new BeautyProduct { Name = "EyebrowPencil", Price = 18},
        new BeautyProduct { Name = "DressingCase", Price = 36 },
        new BeautyProduct { Name = "PowderPuff", Price = 16 },
        new BeautyProduct { Name = "MakeupPowder", Price = 29},
        new BeautyProduct { Name = "LipGlosscolor", Price = 29},
        new BeautyProduct { Name = "EysShadow", Price = 32},
        new BeautyProduct { Name = "EyebrowForceps", Price = 28},
        new BeautyProduct { Name = "FalseEyelashes", Price = 39},
        new BeautyProduct { Name = "MascaraCream", Price = 62}
};
        public IEnumerable<BeautyProduct> BeautyProducts
        {
            get { return _Beautyproducts; }
        }
    }
}