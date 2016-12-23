using Reflect.Context.Interfaces;
using Reflect.Context.Repositories;

namespace Reflect.Context.UnitOfWork
{
    public class OdelUnitOfWork : IUnitOfWork
    {
        private readonly AzureContext _context;

        public OdelUnitOfWork(AzureContext context)
        {
            _context = context;

            Questions = new QuestionRepository(_context);
        }

        public IQuestionRepository Questions { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
