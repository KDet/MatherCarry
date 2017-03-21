using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MatherCarry.Triangle.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            //ViewData["Message"] = "Your application description page.";
			return View();
        }
		public IActionResult About2()
		{
			//ViewData["Message"] = "Your application description page.";
			return View();
		}
		public IActionResult Service()
		{
			//ViewData["Message"] = "Your application description page.";
			return View();
		}
		public IActionResult Pricing()
		{
			//ViewData["Message"] = "Your application description page.";
			return View();
		}
		public IActionResult Contact()
		{
			//ViewData["Message"] = "Your application description page.";
			return View();
		}
		public IActionResult Contact2()
		{
			//ViewData["Message"] = "Your application description page.";
			return View();
		}
		public IActionResult ComingSoon()
        {
            return View();
        }
        public IActionResult ComingSoon2()
        {
             return View();
        }

        public IActionResult Error()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}

		public IActionResult BlogDefault()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}
		public IActionResult BlogTimeline()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}
		public IActionResult Blog2ColumnsRightSidebar()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}
		public IActionResult Blog1ColumnLeftSidebar()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}
		public IActionResult BlogMasonary()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}
		public IActionResult BlogDetails()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}

		public IActionResult PortfolioDefault()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}
		public IActionResult PortfolioIsotope3ColumnsRightSidebar()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}
		public IActionResult Portfolio3ColumnsRightSidebar()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}
		public IActionResult Portfolio3ColumnsLeftSidebar()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}
		public IActionResult Portfolio2Columns()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}
		public IActionResult PortfolioDetails()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}

		public IActionResult Shortcodes()
		{
			//ViewData["Message"] = "Your contact page.";
			return View();
		}
    }
}
