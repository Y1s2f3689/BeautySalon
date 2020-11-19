using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Concrete;

namespace Vic.SportsStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IProductsRepository Productsrepository { get; set; }
            = new EFProductRepository();

        public int PageSize = 3;
        public ViewResult List(int page = 1)
        {
            //1,2,3   4,5,6   7,8,9
            //M-V-C
            //M -> Productsrepository.Products
            //V -> View
            //C -> ProductController

            var model = Productsrepository
                .Products
                .OrderBy(p => p.ProductId)
                .Skip((page-1)*PageSize)
                .Take(PageSize);

            return View(model);
               // repository
               // .Products
               // .OrderBy(p => p.ProductId)
               // .Skip((page - 1) * PageSize)
               // .Take(PageSize)); ;
        }
       
    }
}