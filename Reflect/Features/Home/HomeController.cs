using Reflect.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reflect.Features.Home
{ 
    public class HomeController : Controller
    {
        public ActionResult Index() {
            return View();
        }
      [HttpPost]
      public ActionResult Ask(string title, string content) {
         using(var context = new AzureContext()) {
            context.Questions.Add(new Context.Entites.Question() {
               Title = title,
               Content = content,
               Id = 0,
               Date = DateTime.Now
            });

            context.SaveChanges();
         }

         return RedirectToAction("Index");

      }

    }
}