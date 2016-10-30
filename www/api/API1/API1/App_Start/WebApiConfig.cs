﻿using System.Web.Http;

namespace API1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
  //          config.Routes.MapHttpRoute(
  //    name: "DefaultApi2",
  //    routeTemplate: "api/{controller}/{action}/{moduleId}",
  //    defaults: new { moduleId = RouteParameter.Optional }
  //);
        }
    }
}
