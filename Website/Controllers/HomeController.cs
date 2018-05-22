using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate; 
using NHibernateCookbook.Framework.Entities;
using NHibernateCookbook.WebSite.Filters;

namespace NHibernateCookbook.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [DbTransactionFilter]
        public JsonResult Person()
        {
            ISession session = MvcApplication.SessionFactory.GetCurrentSession();
            Person person = session.Get<Person>(1);
            return Json(person, JsonRequestBehavior.AllowGet);
        }
    }
}