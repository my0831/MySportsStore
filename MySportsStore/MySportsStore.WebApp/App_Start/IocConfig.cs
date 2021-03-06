using Autofac;
using Autofac.Integration.Mvc;
using MySportsStore.Domain.Abstract;
using MySportsStore.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySportsStore.WebApp
{
    public class IocConfig
    {
        public static void ConfigIoc()
        {
            var builder = new ContainerBuilder();

            builder
                .RegisterControllers(typeof(MvcApplication).Assembly)
                .PropertiesAutowired();

            builder
                .RegisterInstance<IProductsRepository>(new
            EFProductRepository())
                .PropertiesAutowired();

            //builder
            //    .RegisterInstance<IOrderProcessor>(new
            //EmailOrderProcessor(new EmailSettings()))
            //    .PropertiesAutowired();


            builder.RegisterType<EmailSettings>()
                .PropertiesAutowired();

            builder.RegisterType<EmailOrderProcessor>()
                .As<IOrderProcessor>()
                .PropertiesAutowired();


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}