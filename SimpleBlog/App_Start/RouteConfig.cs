using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlog.Controllers;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] {typeof (PostsController).Namespace};

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("TagForRealThisTime", "tag/{idandSlug}", new { controller = "Posts", action = "Tag" }, namespaces);
            routes.MapRoute("Tag", "tag/{id}-{slug}", new {controller = "Posts", action = "Tag"}, namespaces);

            routes.MapRoute("PostForRealThisTime", "post/{idandSlug}", new {controller = "Posts", action = "Show"}, namespaces);
            routes.MapRoute("Post", "post/{id}-{slug}", new {controller = "Post", action = "Show"}, namespaces);

            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login"},  namespaces);
            routes.MapRoute("Logout", "logout", new { controller = "Auth", action = "logout" }, namespaces);


            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" }, namespaces);

            routes.MapRoute("Sidebar", "", new { controller = "Layout", action = "Sidebar" }, namespaces);
        }
    }
}
