﻿using SpotzerOrderApi.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace SpotzerOrderApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
           // config.Filters.Add(new SpotzerOrderApi.ExceptionHandling.KeyNotFoundxceptionFilterAttribute());
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.Filters.Add(new CustomExceptionFilter());


            // config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
