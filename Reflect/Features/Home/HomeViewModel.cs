using Reflect.Context.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reflect.Features.Home
{
    public class HomeViewModel
    {
      public HomeViewModel(IEnumerable<Question> questions) {
         Questions = questions;
      }
      public IEnumerable<Question> Questions { get; set; }
    }
}