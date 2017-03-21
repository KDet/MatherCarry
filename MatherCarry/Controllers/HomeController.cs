using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MatherCarry.Models;

namespace MatherCarry.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Index(ContactModel model)
		{
			var d = model;

			ViewBag.Message = "Your application description page.";

			return View();
		}

  //      public IActionResult About()
  //      {
  //          ViewData["Message"] = "Your application description page.";

  //          return View();
  //      }
		//[HttpPost]
  //      public ActionResult About(ContactModel model)
  //      {
  //          var d = model;

  //          ViewBag.Message = "Your application description page.";

  //          return View();
  //      }

  //      public IActionResult Contact()
  //      {
  //          ViewData["Message"] = "Your contact page.";

  //          return View();
  //      }

        public IActionResult Error()
        {
            return View();
        }
    }
}
