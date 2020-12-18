using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exec02.FrontEnd.Application.News;
using Exec02.FrontEnd.Application.ViewModels;

namespace Exec02.FrontEnd.Site.Controllers
{
	public class HomeController : Controller
	{
        public HomeController()
		{
		}
		public ActionResult Index()
		{
			return View();
		}		
	}
}