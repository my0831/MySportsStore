using MySportsStore.Domain.Abstract;
using MySportsStore.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySportsStore.Domain.Entities;


namespace MySportsStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository = new InMemoryProductRepository();

       
        public ViewResult List()
        {
            return View(repository.Products);

            }
    }
}