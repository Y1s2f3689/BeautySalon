using Jennifer.BeautySalon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jennifer.BeautySalon.Domain.Abstract
{
    public interface IBeautyProductsRepository
    {
        IEnumerable<BeautyProduct> BeautyProducts { get; }
    }
}
