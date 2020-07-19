using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using NHibernate;

namespace TestHeros.Migrator.Api.Filters
{
    public class NHibernateSessionFilter: IAsyncActionFilter
    {
        private readonly ISession _session;
        public NHibernateSessionFilter(ISession session)
        {
            _session = session;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _session.BeginTransaction();
            var transaction = _session.Transaction;

            try
            {
                await next.Invoke();

                if (transaction.IsActive && !transaction.WasCommitted)
                {
                    transaction.Commit();
                }
            }
            catch (Exception)
            {
                if (transaction.IsActive && !transaction.WasRolledBack)
                {
                    transaction.Rollback();
                }

                throw;
            }
            
        }
    }
}
