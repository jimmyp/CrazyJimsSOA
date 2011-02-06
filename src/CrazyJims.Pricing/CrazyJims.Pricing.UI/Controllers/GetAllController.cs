using System;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using CrazyJims.Pricing.UI.Models;

namespace CrazyJims.Pricing.UI.Controllers
{
    public class GetAllController : Controller
    {
        [HttpGet]
        public JsonResult Index()
        {
                return Json(new Collection<ProductPrice>()
                                {
                                    new ProductPrice(new Guid("356d8f78-83a7-48c4-b3d9-4c40f7abc5b1"), new Money(356.34m)),
                                    new ProductPrice(new Guid("65f18369-ec07-41b4-b74b-a7c710500c72"), new Money(12.24m))
                                },
                            JsonRequestBehavior.AllowGet
                    );
        }

    }
}
