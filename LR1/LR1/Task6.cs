﻿using System;
using System.Web;

namespace LR1
{
    public class Task6 : IHttpHandler
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Члены IHttpHandler

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.HttpMethod == "GET")
            {
                var res = context.Response;
                res.WriteFile("D:\\BSTU\\PIS-3c6s\\LR1\\LR1\\Task6.html");
            }
            else if (context.Request.HttpMethod == "POST")
            {
                var x = Convert.ToInt32(context.Request.Form.Get("x"));
                var y = Convert.ToInt32(context.Request.Form.Get("y"));

                var res = context.Response;
                res.ContentType = "text/plain";
                res.Write(x * y);
            }
        }

        #endregion
    }
}
