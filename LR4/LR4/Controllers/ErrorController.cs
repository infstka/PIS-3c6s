// Контроллер для обработки ошибок

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LR4.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult NotFound()
        {
            ViewBag.url = Request.RawUrl; // Получаем запрошенный URL
            ViewBag.method = Request.HttpMethod; // Получаем HTTP метод запроса
            return View(); // Возвращаем представление для отображения ошибки
        }
    }
}

// Когда возникает ошибка, браузер пользователя перенаправляется на действие NotFound контроллера Error.
// Это действие устанавливает значения двух свойств
// ViewBag - url и method - и возвращает представление для отображения информации об ошибке.