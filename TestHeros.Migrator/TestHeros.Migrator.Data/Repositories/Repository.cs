using System;
using System.Linq;
using System.Threading.Tasks;
using NHibernate;
using TestHeros.Migrator.Domain.Core.Entities;
using TestHeros.Migrator.Domain.Core.Interfaces;

namespace TestHeros.Migrator.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly ISession Session;

        protected Repository(ISession session)
        {
            Session = session ?? throw new ArgumentNullException(nameof(session));
        }

        public Task AddAsync(TEntity entity)
        {
            return Session.SaveAsync(entity);
            //return Session.FlushAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return Session.Query<TEntity>();
        }

        public Task<TEntity> GetByIdAsync(object id)
        {
            return Session.GetAsync<TEntity>(id);
        }

        public Task RemoveAsync(object id)
        {
            return Session.DeleteAsync(id);
        }

        public Task UpdateAsync(TEntity entity)
        {
            return Session.UpdateAsync(entity);
        }
    }


}
