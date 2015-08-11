using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFirstWebsite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //.axd are virtual files that cannot be reached, 
            //so the routing engine should ignore it
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Routes are checked sequentially from the top, order of routes matter

            routes.MapRoute("Stuff",
                "stuff/{name}",
                new { controller = "Stuff", action = "Search", name = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}