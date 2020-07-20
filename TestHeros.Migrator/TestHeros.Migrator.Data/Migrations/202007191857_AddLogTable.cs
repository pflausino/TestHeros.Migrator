using System;
using FluentMigrator;

namespace TestHeros.Migrator.Data.Migrations
{
    [Migration(202007191857)]
    public class AddLogTable : Migration
    {
        public override void Up()
        {
            Create.Table("Log")
                            .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                            .WithColumn("Text").AsString();
        }

        public override void Down()
        {
            Delete.Table("Log");
        }
    }
}
