using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class InformationController : Controller
    {
        // GET: Information
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DynamischeWebseiten()
        {
            return View();
        }

        public ActionResult FaktenASP()
        {
            return View();
        }

        public ActionResult Framework()
        {
            return View();
        }

        public ActionResult MVC()
        {
            return View();
        }
    }
}