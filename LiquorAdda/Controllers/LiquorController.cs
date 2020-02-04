using LiquorAdda.Core.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiquorAdda.Controllers
{
    public class LiquorController : Controller
    {
        private LiquorOperation _liquorOpeartion;

        public LiquorController()
        {
            _liquorOpeartion = new LiquorOperation();
        }

        [Route("/Liquor/LiquorList")]
        public ActionResult LiquorList()
        {
            return View();
        }

        [HttpPost]
        [Route("/Liquor/GetLiquorList")]
        public ActionResult GetLiquorList()
        {
            try
            {
                //Log
                var list = _liquorOpeartion.GetLiquorList();
                return Json(list);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}