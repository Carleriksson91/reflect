using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Reflect.Context.UnitOfWork;
using Reflect.DI;
using Reflect.Main.ViewEngines;

namespace Reflect
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGloablFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //ViewEngines.Engines.Remove(ViewEngines.Engines.OfType<WebFormViewEngine>().First());
            //ViewEngines.Engines.Remove(ViewEngines.Engines.OfType<RazorViewEngine>().First());
            //ViewEngines.Engines.Add(new LayoutViewEngine());
            ViewEngines.Engines.Add(new FeaturesLayoutViewEngine());
            var s = new DependencyInjector();
            s.register_all_types_of_an_interface();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}