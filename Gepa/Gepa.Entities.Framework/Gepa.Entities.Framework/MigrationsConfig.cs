using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework
{
    public class MigrationsConfig : DbMigrationsConfiguration<EntityModel>
    {
        public MigrationsConfig()
        {
            //AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
        }
    }
}
