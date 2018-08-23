using Gepa.Entities.Framework.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.ClassPlans
{
    public class ChoresMap : EntityTypeConfiguration<Chores>
    {
        public ChoresMap()
        {
            this.HasKey(k => k.ChoresId);
        }
    }
}
