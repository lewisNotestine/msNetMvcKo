using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YetAnotherKOApp.Models;

namespace YetAnotherKOApp.Controllers
{
    public class BarfController : Controller
    {
        //
        // GET: /Barf/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Barf()
        {
            var barfList = new BarfModel().Barf();
            return Json(barfList);
        }

    }
}
