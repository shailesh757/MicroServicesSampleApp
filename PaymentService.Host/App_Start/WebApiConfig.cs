﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PaymentService.Host
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //api/{Payment}/{ApiLoginID}/{ApiTransactionKey}/{amount}/{id:int}

            config.Routes.MapHttpRoute(
               name: "PaymentApi",
               routeTemplate: "api/{controller}/{ApiLoginID}/{ApiTransactionKey}",
               defaults: new { controller = "Payment", ApiLoginID = "9AdTm46F", ApiTransactionKey = "3KXG4gy5Qg59Rz7v", id = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
            // To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
            // For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();

            // To disable tracing in your application, please comment out or remove the following line of code
            // For more information, refer to: http://www.asp.net/web-api
        }
    }
}
