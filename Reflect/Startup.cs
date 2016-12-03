using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Reflect.Main.ViewEngines;

namespace Reflect
{
    public class Startup : HttpApplication
    {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGloablFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewEngines.Engines.Remove(ViewEngines.Engines.OfType<WebFormViewEngine>().First());
            ViewEngines.Engines.Remove(ViewEngines.Engines.OfType<RazorViewEngine>().First());
            //ViewEngines.Engines.Add(new LayoutViewEngine());
            ViewEngines.Engines.Add(new FeaturesLayoutViewEngine());
        }
    }
}