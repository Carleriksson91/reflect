using System.Web.Mvc;

namespace Reflect
{
    public class FilterConfig
    {
        public static void RegisterGloablFilters(GlobalFilterCollection collection) {
           collection.Add(new HandleErrorAttribute());
        }
    }
}