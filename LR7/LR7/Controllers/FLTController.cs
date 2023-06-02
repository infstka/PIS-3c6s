using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LR7.Controllers
{
    public class FLTController : Controller
    {
        // GET: FLT
        [Authorize(Roles = "Guest,Employer,Administrator")]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Employer")]
        public ActionResult FLT_LV()
        {
            return View();
        }
        [Authorize(Roles = "Employer")]
        public ActionResult FLT_LU()
        {
            return View();
        }
        [Authorize(Roles = "Employer")]
        public ActionResult FLT_LZ()
        {
            return View();
        }
    }
}