using Jennifer.BeautySalon.Domain.Entities;
using System.Collections.Generic;

namespace Jennifer.BeautySalon.Domain.Abstract
{
    public interface IBeautyProductsRepository
    {
        IEnumerable<BeautyProduct> BeautyProducts { get; }
    }
}
