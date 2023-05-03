using System.Web.Mvc;

namespace LR5b.Filters
{
    public class AAFilterAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("--AFTER--");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.Form["q"] == "a")
            {
                filterContext.HttpContext.Response.Write("--BEFORE--");
                //filterContext.HttpContext.Response.End();
            }
        }
    }
}