using Jennifer.BeautySalon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jennifer.BeautySalon.WebApp.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<BeautyProduct> BeautyProducts { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}