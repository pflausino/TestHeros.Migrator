using System;
using System.Linq;
using System.Threading.Tasks;
using TestHeros.Migrator.Domain.Core.Entities;

namespace TestHeros.Migrator.Domain.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task AddAsync(TEntity entity);

        Task<TEntity> GetByIdAsync(object id);

        IQueryable<TEntity> GetAll();

        Task UpdateAsync(TEntity entity);

        Task RemoveAsync(object id);
    }
}   
