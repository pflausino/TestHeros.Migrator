using System;
using System.Collections.Generic;
using FluentMigrator;
using TestHeros.Migrator.Domain.Entities;

namespace TestHeros.Migrator.Data.Migrations
{
    [Migration(202007192311)]
    public class InsertHerosTable : Migration
    {
        public override void Up()
        {
            var batman = new { HerosId = Guid.NewGuid().ToString(), Name = "Batman", IdentityName = "Bruce Wayne", Strong = 3, Intelligent = 9, Resistence = 5 };

            IDictionary<string, string> kvp = new Dictionary<string, string>();

            Insert.IntoTable("Heros").Row(batman);
        }

        public override void Down()
        {
            Delete.Table("Heros");
        }
    }
}

