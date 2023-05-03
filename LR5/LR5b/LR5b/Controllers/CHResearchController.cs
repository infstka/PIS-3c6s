using System;
using System.Web.Mvc;
using System.Web.UI;

namespace LR5b.Controllers
{
    public class CHResearchController : Controller
    {
        static int x = 0;

        // Обработка GET-запроса на адрес /CHResearch/AD
        [HttpGet]
        // Установка параметров кэширования для этого действия.
        // Результат действия будет кэшироваться на сервере на 5 секунд
        [OutputCache(Duration = 5, Location = OutputCacheLocation.Server)]
        public ActionResult AD()
        {
            // Инкремент значения статической переменной
            x++;
            // Возвращает контент с сообщением, включающим текущее значение статической переменной и время запроса.
            return Content($"AD: x = {x} ({DateTime.Now})");
        }

        // Обработка POST-запроса на адрес /CHResearch/AP
        [HttpPost]
        // Установка параметров кэширования для этого действия.
        // Результат действия будет кэшироваться на сервере на 7 секунд
        [OutputCache(Duration = 7, Location = OutputCacheLocation.Server, VaryByParam = "x")]
        public ActionResult AP(string x, string y)
        {
            // Возвращает контент с сообщением, включающим переданные параметры и время запроса.
            return Content($"AP: x = {x}, y = {y} ({DateTime.Now})");
        }
    }
}
