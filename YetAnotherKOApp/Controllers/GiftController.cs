using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YetAnotherKOApp.Models;

namespace YetAnotherKOApp.Controllers
{
    public class GiftController : Controller
    {
        //
        // GET: /Gift/

        public ActionResult Index()
        {
            var initialState = new GiftModel[] 
            {
                (GiftModel) GiftModel.Create(title: "Tall Hat", price: 12.34),
                (GiftModel) GiftModel.Create(title: "Long Cloak", price: 56.78)
            };

            return View(initialState);
        }

    }
}
