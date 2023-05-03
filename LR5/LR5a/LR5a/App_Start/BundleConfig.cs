// Определение класса BundleConfig, который регистрирует бандлы для скриптов и стилей
using System.Web;
using System.Web.Optimization;

namespace LR5a
{
    public class BundleConfig
    {
        // Определение метода RegisterBundles, который регистрирует бандлы
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Регистрация бандла для jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Регистрация бандла для jQuery Validation
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Регистрация бандла для Modernizr
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // Регистрация бандла для Bootstrap
            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            // Регистрация бандла для стилей
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}