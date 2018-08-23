using Gepa.Entities.Framework.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.ClassPlans
{
    public class EvaluetionMap : EntityTypeConfiguration<Evaluetion>
    {
        public EvaluetionMap()
        {
            this.HasKey(k => k.EvaluetionId);
            this.HasMany(e => e.StudentNote)
                .WithOptional(e => e.Evaluetion)
                .WillCascadeOnDelete(false);
        }
    }
}
