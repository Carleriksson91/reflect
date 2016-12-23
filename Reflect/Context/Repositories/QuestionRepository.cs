using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Reflect.Context.Entites;
using Reflect.Context.Interfaces;

namespace Reflect.Context.Repositories
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(AzureContext context) : base(context) {
            
        }

    }
}