using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CrazyJims.Common;

namespace CrazyJims.Products.UI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class ProductsMvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Template",
                "Template/{templateName}",
                new { controller = "Template", action = "GetTemplate" });

            routes.MapRoute(
                "Products", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "products", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);

            ContainerConfig.Configure();

            ControllerBuilder.Current.SetControllerFactory(new ControllerFactory());
        }
    }
}