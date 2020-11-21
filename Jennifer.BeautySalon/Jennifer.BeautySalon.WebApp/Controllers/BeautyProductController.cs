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


    public ViewResult List()
        {
            return View(BeautyProductsRepository.BeautyProducts);
        }
    }
}