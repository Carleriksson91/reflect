using Reflect.Context;
using Reflect.Context.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reflect.Context.Interfaces;
using Reflect.Context.UnitOfWork;

namespace Reflect.Features.Home
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            //var model = new HomeViewModel(GetQuestions());
            //return View(model);
            return View();
        }
        [HttpPost]
        public ActionResult Ask(string title, string content)
        {
            unitOfWork.Questions.Add(new Question()
            {
                Title = title,
                Content = content,
                Id = 0,
                Date = DateTime.Now
            });
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IEnumerable<Question> GetQuestions()
        {
            var questions = new List<Question>();
            using (var context = new AzureContext())
            {
                questions.AddRange(context.Questions.OrderByDescending(x => x.Date));
            }

            return questions;
        }
    }
}