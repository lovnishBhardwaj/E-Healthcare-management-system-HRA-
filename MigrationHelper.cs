using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.FluentDbMigrations.Migrations
{
    public static class DBTableName
    {
        public const string Department = "Department";
        public const string Insurancs = "Insurance";

    }



    public class MigrationHelper
    {
        internal static object CreateDepartment( string name, string desc)
        {
            return new
            {
                Name = name,
                Desc = desc,
            };
        }
        internal static object CreateDepartment(int id,string name, string desc)
        {
            return new
            {
                Id=id,
                Name = name,
                Desc = desc,
            };
        }
        internal static object CreateInsurance(int id, string name, string insurer, int amount)
        {
            return new
            {
                Insurance_Id = id,
                Insurance_Holder = name,
                Insurer = insurer,
                Insure_Amount = amount,
            };
        }

    }
}
