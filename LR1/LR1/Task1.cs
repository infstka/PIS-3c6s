using System;
using System.Web;

namespace LR1
{
    public class Task1 : IHttpHandler
    {
        #region Члены IHttpHandler

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            res.Write("Task1<br>");
            string result = "GET-Http-BGS:<br> ParamA = " + context.Request.QueryString["ParamA"] + " <br>ParamB = " + context.Request.QueryString["ParamB"];
            context.Response.Write(result);
        }

        #endregion
    }
}
