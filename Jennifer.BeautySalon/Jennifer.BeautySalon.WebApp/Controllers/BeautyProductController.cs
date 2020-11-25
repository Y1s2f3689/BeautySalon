using Jennifer.BeautySalon.Domain.Abstract;
using Jennifer.BeautySalon.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jennifer.BeautySalon.Domain.Entities;
using Jennifer.BeautySalon.WebApp.Models;

namespace Jennifer.BeautySalon.WebApp.Controllers
{
    public class BeautyProductController : Controller
    {
        public IBeautyProductsRepository BeautyProductsRepository { get; set; }
            = new EFBeautyProductRepository();

        public int PageSize = 3;

        public ViewResult List(int page = 1)
        {

            {
                BeautyProductsListViewModel model = new BeautyProductsListViewModel

                {
                    BeautyProducts = BeautyProductsRepository
                    .BeautyProducts
                    .OrderBy(p => p.BeautyProductId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),

                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = page,
                        ItemsPerPage = PageSize,
                        TotalItems = BeautyProductsRepository.BeautyProducts.Count()
                    };

                return View(model);
                }
                
            }
        }
}
