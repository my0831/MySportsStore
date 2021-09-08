using MySportsStore.Domain.Abstract;
using MySportsStore.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySportsStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository = new InMemoryProductRepository();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}