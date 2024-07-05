using FluentMigrator;
using FluentMigrator.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.FluentDbMigrations.Migrations
{
    [Migration(20211214100000)]
    public class Migration_20220411100000:Migration
    {
        public override void Down()
        {
            Delete.Table(DBTableName.Department);
        }

        public override void Up()
        {
            Create.Table(DBTableName.Department)
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity(11, 1)
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Desc").AsString().NotNullable();
        }
    }

}
