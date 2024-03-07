﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Filters;
using Ultimus.Utilitarios;

namespace AtencionTramites
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}/{id2}",
                defaults: new { id = RouteParameter.Optional, id2 = RouteParameter.Optional }
            );


            config.Filters.Add(new UnhandledExceptionFilter());

            // Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
            // To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
            // For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();
        }
    }

    public class UnhandledExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            UltimusLogs UltimusLogs = new UltimusLogs("WebApiConfig");
            UltimusLogs.Error("[WebApiApplication / Application_Error] " + context.Exception.ToString());
        }
    }
}