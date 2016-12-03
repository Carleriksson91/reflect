using Reflect.Context.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflect.Context {
   public class AzureContext: DbContext {

      public AzureContext()
         : base("name=azure") {
      }
      protected override void OnModelCreating(DbModelBuilder modelBuilder) {
         modelBuilder.Entity<Question>().HasMany<Tag>(x => x.Tags);

      }
      

      public virtual DbSet<Question> Questions {get; set;}
      public virtual DbSet<Tag> Tags { get; set; }
      

   }
}
