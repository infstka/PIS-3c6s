using System;
using System.Web.Mvc;
using LR5b.Filters;

namespace LR5b.Controllers
{
    public class AResearchController : Controller
    {
        [AAFilter]
        public ActionResult AA() { return Content("AA"); }

        [ARFilter]
        public ActionResult AR() { return Content("AR"); }

        [AEFilter]
        public ActionResult AE()
        {
            try
            {
                int a = 10, b = 2;
                int c = a / b;
                return Content("Result: " + c.ToString());
            }
            catch (DivideByZeroException ex)
            {
                ViewBag.Message = "Error: " + ex.Message;
                return View("Error");
            }
        }
    }
}