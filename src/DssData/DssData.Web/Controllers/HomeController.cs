using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace DssData.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Dashboard()
		{
			return View();
		}
		public ActionResult Index()
		{
			var mvcName = typeof(Controller).Assembly.GetName();
			var isMono = Type.GetType("Mono.Runtime") != null;

			ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData["Runtime"] = isMono ? "Mono" : ".NET";

			return View();
		}

		public ActionResult LoginAsync(string username, string password)
		{
			
			var result = new { };
			JsonResult jsonResult = Json(result);
			jsonResult.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
			return jsonResult;
		}
	}
}
