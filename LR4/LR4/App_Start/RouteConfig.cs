// Определение пространства имен и использование необходимых библиотек
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

// Объявление пространства имен проекта
namespace LR4
{
    // Определение класса настроек маршрутизации
    public class RouteConfig
    {
        // Определение статического метода RegisterRoutes, который будет вызываться в файле Global.asax.cs для регистрации маршрутов
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Игнорирование запросов к ресурсам вида {resource}.axd/{*pathInfo}
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Определение маршрута по умолчанию с шаблоном URL вида "{controller}/{action}/{id}", где id - необязательный параметр
            // При этом, если не указаны ни контроллер, ни действие, то будет вызываться действие Index контроллера Dict
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Dict", action = "Index", id = UrlParameter.Optional }
            );

            // Определение маршрута для обработки ошибок 404, соответствующего любому URL запросу
            // При этом, будет вызываться действие NotFound контроллера Error, в случае, если указанный URL не был обработан другими маршрутами
            routes.MapRoute(
                name: "Error",
                url: "{*url}",
                defaults: new { controller = "Error", action = "NotFound" }
            );
        }
    }
}