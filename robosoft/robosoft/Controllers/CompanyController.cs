using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace robosoft
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Leadership()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }
    }
}