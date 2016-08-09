using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

// A namespace is a collection of classes hierarchy
namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // movies/popular where movies  = controller and popular()
            // moviesController.Index()

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            // New custom route for categories
            routes.MapRoute(
            "Categories",
            "movies/{category}",
            new { controller = "Movies", action = "Categories" },
            new { category = @""});

            routes.MapRoute(
            "MoviesbyRealeaseDate",
            "movies/released/{year}/{month}",
            new { controller = "Movies", action = "ByReleaseDate"},
            new { year = @"\d{4}", month = @"\d{2}" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
