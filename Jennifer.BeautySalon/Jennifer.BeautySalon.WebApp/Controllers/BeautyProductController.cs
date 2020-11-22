using Jennifer.BeautySalon.Domain.Abstract;
using Jennifer.BeautySalon.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jennifer.BeautySalon.WebApp.Controllers
{
    public class BeautyProductController : Controller
    {
        public IBeautyProductsRepository BeautyProductsRepository { get; set; }
            = new EFBeautyProductRepository();

        public int PageSize = 3;

        public ViewResult List(int page = 1)

        {
            var model = BeautyProductsRepository
              .BeautyProducts
              .OrderBy(p => p.BeautyProductId)
              .Skip((page - 1) * PageSize)
              .Take(PageSize);

            return View(model);
         }
        
              
    }
}