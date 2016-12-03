using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflect.Context.Entites {
   public class Question {
      public int Id { get; set; }
      [Required]
      public string Title { get; set; }
      [Required]
      public string Content { get; set; }
      public DateTime Date { get; set; }
      public virtual ICollection<Tag> Tags { get; set; }

      
   }
}
