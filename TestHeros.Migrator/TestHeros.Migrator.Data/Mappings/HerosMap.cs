using System;
using FluentNHibernate.Mapping;
using TestHeros.Migrator.Domain.Entities;

namespace TestHeros.Migrator.Data.Mappings
{
    public class HeroMap : ClassMap<Hero>
    {
        public HeroMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.GuidComb();
            Map(x => x.Name);
            Map(x => x.IdentityName);
            Map(x => x.Strong);
            Map(x => x.Resistence);
            Map(x => x.Intelligent);
            Table("Heros");
        }
    }
}
