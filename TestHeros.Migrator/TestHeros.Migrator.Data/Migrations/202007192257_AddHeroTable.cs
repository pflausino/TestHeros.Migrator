using System;
using FluentMigrator;

namespace TestHeros.Migrator.Data.Migrations
{
    [Migration(202007192257)]
    public class AddHeroTable : Migration
    {
        public override void Up()
        {
            Create.Table("Heros")
                .WithColumn("HerosId").AsGuid().PrimaryKey()
                .WithColumn("Name").AsString()
                .WithColumn("IdentityName").AsString()
                .WithColumn("Strong").AsInt16()
                .WithColumn("Intelligent").AsInt16()
                .WithColumn("Resistence").AsInt16();
        }

        public override void Down()
        {
            Delete.Table("Heros");
        }
    }
}
