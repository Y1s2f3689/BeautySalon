using Jennifer.BeautySalon.Domain.Entities;
using System.Collections.Generic;

namespace Jennifer.BeautySalon.WebApp.Controllers
{
    internal class BeautyProductsListViewModel
    {
        internal IEnumerable<BeautyProduct> BeautyProducts;

        public PagingInfo PagingInfo { get; internal set; }
    }
}