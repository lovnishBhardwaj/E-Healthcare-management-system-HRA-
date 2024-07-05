using FluentMigrator;
using FluentMigrator.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.FluentDbMigrations.Migrations
{
    [Migration(20220412152806)]
    public class Migration_20220412152806:Migration
    {
        public override void Down()
        {
            Delete.Table(DBTableName.Insurancs);
        }

        public override void Up()
        {
            Create.Table(DBTableName.Insurance)
                .WithColumn("Insurance_Id").AsInt32().NotNullable().PrimaryKey().Identity(11, 1)
                .WithColumn("Insurance_Holder").AsString().NotNullable()
                .WithColumn("Insurer").AsString().NotNullable()
                .WithColumn("Insure_Amount").AsInt32().NotNullable();
        }
    }

}