using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnockoutTestApplication.ViewModel;

namespace KnockoutTestApplication.Controllers
{
    public class PersonController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Countries = new List<ICountry>()
            {
               Country.Create(
                id: 1,
                name: "India"),
                Country.Create(
                id: 2,
                name: "USA"),
                Country.Create(
                id: 3, 
                name: "France")
            };

            //can be created from factory or whatever.
            var viewModel = PersonViewModel.Create(
                id: 1,
                name: "blungus",
                dob: DateTime.Now);

            return View(viewModel);
        }

        [HttpPost]
        public JsonResult SavePersonDetails(IPersonViewModel viewModel)
        {
            return Json(new { });
        }

    }
}
