using Reflect.Context;
using Reflect.Context.Entites;
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
         //var model = new HomeViewModel(GetQuestions());
            //return View(model);
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

      [HttpGet]
      public IEnumerable<Question> GetQuestions() {
         var questions = new List<Question>();
         using(var context = new AzureContext()) {
            questions.AddRange(context.Questions.OrderByDescending(x => x.Date));
         }

         return questions;
      }
      }
}