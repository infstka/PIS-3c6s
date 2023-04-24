// Импорт необходимых библиотек
using System.IO;
using System.Web.Mvc;

namespace LR5a.Controllers
{
    public class CResearchController : Controller
    {
        // Обработчик GET-запроса C01
        public string C01()
        {
            // Получаем объект запроса из контекста
            var request = HttpContext.Request;
            // Получаем метод запроса (GET, POST и т.д.)
            var method = request.HttpMethod;
            // Получаем строку с параметрами запроса
            var queryParameters = request.QueryString.ToString();
            // Получаем URI запроса (адрес страницы, на которой находится обработчик)
            var uri = request.Url.AbsoluteUri;
            // Получаем заголовки запроса
            var headers = request.Headers.ToString();
            // Получаем тело запроса, если метод запроса POST
            var body = "";
            if (method == "POST")
                using (var reader = new StreamReader(request.InputStream))
                    body = reader.ReadToEnd();

            // Формируем ответ с информацией о запросе
            var response = string.Format("Метод запроса: {0}<br>" +
                                          "Query-параметры: {1}<br>" +
                                          "URI: {2}<br>" +
                                          "Заголовки: {3}<br>" +
                                          "Тело запроса: {4}", method, queryParameters, uri, headers, body);
            return response;
        }

        // Обработчик GET-запроса C02
        public string C02()
        {
            // Получаем объект ответа из контекста
            var response = HttpContext.Response;
            // Получаем код ответа (например, 200 для успешного запроса)
            var statusCode = response.StatusCode;
            // Получаем сообщение, соответствующее коду ответа (например, "OK" для кода 200)
            var statusMessage = response.Status;
            // Получаем заголовки ответа
            var headers = response.Headers;

            // Формируем ответ с информацией о ответе
            return $"Код ответа: {statusCode}<br>Сообщение ответа: {statusMessage}<br>Заголовки: {headers}<br>";
        }
    }
}