using System.Web.Mvc;
using System.Web.Routing;

namespace LR5a
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            // ===================================  MResearch: M01  ===================================

            routes.MapRoute("M01_5", "V2/MResearch/M01", new { controller = "MResearch", action = "M01" });
            routes.MapRoute("M01_6", "V3/MResearch/X/M01", new { controller = "MResearch", action = "M01" });
            routes.MapRoute("M01_7", "{MResearch}/{M01}/{id}", new { controller = "MResearch", action = "M01" });

            // ===================================  MResearch: M02  ===================================
            routes.MapRoute("M02_1", "V2", new { controller = "MResearch", action = "M02" });
            routes.MapRoute("M02_2", "V2/MResearch", new { controller = "MResearch", action = "M02" });
            routes.MapRoute("M02_3", "MResearch/M02", new { controller = "MResearch", action = "M02" });
            routes.MapRoute("M02_4", "V2/MResearch/M02", new { controller = "MResearch", action = "M02" });
            routes.MapRoute("M02_5", "V3/MResearch/X/M02", new { controller = "MResearch", action = "M02" });

            // ===================================  MResearch: M03  ===================================
            routes.MapRoute("M03_1", "V3", new { controller = "MResearch", action = "M03" });
            routes.MapRoute("M03_2", "V3/MResearch/X", new { controller = "MResearch", action = "M03" });
            routes.MapRoute("M03_3", "V3/MResearch/X/M03", new { controller = "MResearch", action = "M03" });

            // ======================================  CResearch  =====================================
            routes.MapRoute("C01", "CResearch/C01", new { controller = "CResearch", action = "C01" });
            routes.MapRoute("C02", "CResearch/C02", new { controller = "CResearch", action = "C02" });

            // ======================================  404 Error  =====================================
            routes.MapRoute("MXX", "MResearch/MXX", new { controller = "MResearch", action = "MXX" });
        }
    }
}
