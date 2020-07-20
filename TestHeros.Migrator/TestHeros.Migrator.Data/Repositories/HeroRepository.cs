using System;
using NHibernate;
using TestHeros.Migrator.Domain.Entities;
using TestHeros.Migrator.Domain.Interfaces;

namespace TestHeros.Migrator.Data.Repositories
{
    public class HeroRepository : Repository<Hero>, IHeroRepository
    {
        public HeroRepository(ISession session) : base(session)
        {
        }
    }
}
