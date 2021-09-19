using MySportsStore.Domain.Abstract;
using MySportsStore.Domain.Concrete;
using MySportsStore.Domain.Entities;
using MySportsStore.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MySportsStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public const int PageSize = 3;
        public IProductsRepository Repository { get; set; }

        public ViewResult List(string category, int page = 1)
        {
            var result = Repository
                .Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize);
             
            var pagingInfo = new PagingInfo()
            {
                CurrentPage = page,
                ItemsPerPage = PageSize,
                TotalItems = Repository
                .Products
                .Where(p => category == null || p.Category == category)
                .Count()
            };

            var vm = new ProductsListViewModel()
            {
                Products = result,
                PagingInfo = pagingInfo,
                CurrentCategory=category,
            };

            return View(vm);

        }
    }
}