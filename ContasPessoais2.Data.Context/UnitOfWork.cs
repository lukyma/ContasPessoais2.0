using CommonServiceLocator;
using ContasPessoais2.Data.Context.Interfaces;
using System;

namespace ContasPessoais2.Data.Context
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>, IDisposable
        where TContext : IDbContext, new()
    {
        private readonly IContextManager<TContext> _contextManager;

        private readonly IDbContext _dbContext;
        private bool _disposed;

        public UnitOfWork(IContextManager<TContext> contextManager)
        {
            _contextManager = contextManager;
            _dbContext = _contextManager.GetContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
