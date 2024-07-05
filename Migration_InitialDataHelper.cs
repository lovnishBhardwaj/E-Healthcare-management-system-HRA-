using FluentMigrator;
using FluentMigrator.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.FluentDbMigrations.Migrations
{
    [Migration(20250101100001)]
    public class Migration_InitialDataHelper1 : Migration
    {
        public override void Down()
        {
            //throw new NotImplementedException();
        }

        public override void Up()
        {
            Insert.IntoTable(DBTableName.Department)
               .WithIdentityInsert()
               .Row(MigrationHelper.CreateDepartment(1, "IT", "IT department"))
               .Row(MigrationHelper.CreateDepartment(2, "HR", "HR department"));
               ;
        }
    }

}
