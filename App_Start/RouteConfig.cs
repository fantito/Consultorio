using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Consultorio
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index" },
                constraints: new { httpmethod = new HttpMethodConstraint(new string[] { "GET" }) }
           );

            routes.MapRoute(
                 name: "Pacientes",
                 url: "pacientes",
                 defaults: new { controller = "Pacientes", action = "Index" },
                 constraints: new { httpmethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            routes.MapRoute(
                 name: "Pacientes_Details",
                 url: "pacientes/details/{id}",
                 defaults: new { controller = "Pacientes", action = "Details" },
                 constraints: new { httpmethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            routes.MapRoute(
                 name: "Pacientes_Edit",
                 url: "pacientes/edit/{id}",
                 defaults: new { controller = "Pacientes", action = "Edit" },
                 constraints: new { httpmethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            routes.MapRoute(
                 name: "Pacientes_Create",
                 url: "pacientes/create",
                 defaults: new { controller = "Pacientes", action = "Create" },
                 constraints: new { httpmethod = new HttpMethodConstraint(new string[] { "GET" }) }
            );

            routes.MapRoute(
                  name: "Pacientes_New",
                  url: "pacientes/create",
                  defaults: new { controller = "Pacientes", action = "Create" },
                  constraints: new { httpmethod = new HttpMethodConstraint(new string[] { "POST" }) }
             );
        }
    }
}
