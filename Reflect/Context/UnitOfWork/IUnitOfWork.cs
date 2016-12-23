using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reflect.Context.Interfaces;

namespace Reflect.Context.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        IQuestionRepository Questions { get; }
    }
}
