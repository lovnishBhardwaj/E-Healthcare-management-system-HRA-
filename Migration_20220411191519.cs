using FluentMigrator;
using FluentMigrator.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.FluentDbMigrations.Migrations
{

   // [Migration(20220411191519)]
    public class Migration_20220411191519 : Migration
    {
        public override void Down()
        {
            Delete.Table("Employee")
        }

        public override void Up()
        {
          Create.Table ("Employee") 
          .withcolumn("Emp_Id").AsInt32().NotNullAnle().PrimaryKey().Identity(1,1)
          .withcolumn("First_Name").AsString()
          .withcolumn("Last_Name").AsString()
          .withcolumn("ADDRESS").AsDateTime()
          .withcolumn("AGE").AsInt32().NotNullAnle()
          .withcolumn("SALARY").AsInt32()
        }
    }

}
