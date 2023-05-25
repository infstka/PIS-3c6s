using System.Web.Mvc;

namespace LR6.Controllers
{
    public class ErrorController : Controller
    {
        [ActionName("404")]
        public ActionResult Error404()
        {
            return View();
        }

    }
}