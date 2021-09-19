using MySportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySportsStore.WebApp.Controllers
{
    public class NavController : Controller
    {

        public IProductsRepository Repository { get; set; }

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = Repository
            .Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x);

            return PartialView(categories);
        }
    }
}