using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiquorAdda.Controllers
{
    public class TestController : Controller
    {
        // GET: Test - Git
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestMethod()
        {
            return Json("test", JsonRequestBehavior.AllowGet);
        }
    }
}