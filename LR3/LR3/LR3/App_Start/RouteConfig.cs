using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LR3
{
    public class RouteConfig
    {
        //Модель (Model) предоставляет данные и реагирует на команды контроллера, изменяя своё состояние
        //Представление(View) отвечает за отображение данных модели пользователю, реагируя на изменения модел
        //Контроллер(Controller) интерпретирует действия пользователя, оповещая модель о необходимости изменений
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           
            routes.MapRoute(
             name: "Dict",
             url: "{controller}/{action}",
             defaults: new { controller = "Dict", action = "Index" },
             constraints: new { controller = "Dict", action = "Index|Add|AddSave|Update|UpdateSave|Delete|DeleteSave" }
         );
            routes.MapRoute("404-catch-all", "{*catchall}",
          new { controller = "Error", action = "NotFound" });


        }
    }
}
