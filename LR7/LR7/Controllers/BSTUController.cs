using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPLab7.Controllers
{
    public class BSTUController : Controller
    {
        // GET: BSTU
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Config()
        {
            return View();
        }
    }
}