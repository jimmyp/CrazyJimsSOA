using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrazyJims.Products.UI.Models;

namespace CrazyJims.Products.UI.Controllers
{
    public class GetAllController : Controller
    {
        [HttpGet]
        public JsonResult Index()
        {
            return Json(new Collection<Product>()
                            {
                                new Product(new Guid("65f18369-ec07-41b4-b74b-a7c710500c72"), "WebScale!!!"),
                                new Product(new Guid("f5c88c72-3f55-48f9-8192-5907792e17fd"), "Absolutley 0 Coupling"),
                                new Product(new Guid("356d8f78-83a7-48c4-b3d9-4c40f7abc5b1"), "IT Businesss Alignment")
                            },
                        JsonRequestBehavior.AllowGet
                );
        }

    }
}
