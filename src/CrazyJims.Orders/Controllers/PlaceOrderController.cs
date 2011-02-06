using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrazyJims.Orders.Models;

namespace CrazyJims.Orders.Controllers
{
    public class PlaceOrderController : Controller
    {
        //
        // GET: /PlaceOrder/

        public ActionResult Index(Guid customerId)
        {
            return Json(new Collection<PlaceOrder>()
                            {
                                new PlaceOrder(new Guid("65f18369-ec07-41b4-b74b-a7c710500c72"), true),
                                new PlaceOrder(new Guid("356d8f78-83a7-48c4-b3d9-4c40f7abc5b1"), false)
                            },
                        JsonRequestBehavior.AllowGet
                );
        }

    }
}
