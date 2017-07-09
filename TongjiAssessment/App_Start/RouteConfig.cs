using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TongjiAssessment
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null, "",
                 new { controller = "Comment", action = "List", category = (string)null, page = 1 }
             );
            routes.MapRoute(null, "Page{page}",
                new { controller = "Comment", action = "List", category = (string)null },
                new { page = @"\d+" }
            );
            routes.MapRoute(null, "{category}",
                new { controller = "Comment", action = "List", page = 1 }
            );
            routes.MapRoute(null,"{category}/Page{page}",
                new { controller = "Comment", action = "List"},
                new {page = @"\d+"}
            );
            routes.MapRoute(
              null,
              url: "{controller}/{action}"
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "CommentRecord", action = "List", id = UrlParameter.Optional }
            );
        }
    }
}
