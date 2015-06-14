using System.Web.Http;

namespace Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

           // config.Routes.MapHttpRoute(
           //    name: "DefaultApi",
           //    routeTemplate: "api/{controller}/{id}",
           //    defaults: new { id = RouteParameter.Optional }
           //); 
            config.Routes.MapHttpRoute(
                name: "NonDefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            ); 
        }
    }
}
