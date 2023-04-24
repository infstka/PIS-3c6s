using System.Web.Mvc;
using System.Web.Routing;

namespace LR5b
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute("AReserach_Action", "AA", new { controller = "AResearch", action = "AA" });
            routes.MapRoute("AReserach_Result", "AR", new { controller = "AResearch", action = "AR" });
            routes.MapRoute("AReserach_Exception", "AE", new { controller = "AResearch", action = "AE" });
            
            routes.MapRoute("CHReserach_AD", "AD", new { controller = "CHResearch", action = "AD" });
            routes.MapRoute("CHReserach_AP", "AP", new { controller = "CHResearch", action = "AP" });

            routes.MapRoute("Default", "{controller}/{action}", new { controller = "AResearch", action = "AA" });
            routes.MapRoute("MXX", "MResearch/MXX", new { controller = "MResearch", action = "MXX" });
        }
    }
}
