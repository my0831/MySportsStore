using MySportsStore.Domain.Entities;
using MySportsStore.WebApp.Infrastructure.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MySportsStore.WebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            IocConfig.ConfigIoc();
            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());

        }
    }
}
