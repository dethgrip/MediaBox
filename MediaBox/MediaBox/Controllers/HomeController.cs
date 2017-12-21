using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaBox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.DataModel dm = Converter.CreateDataModelObject();

            return View(dm);
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

        
    }
}