using Gepa.Entities.Framework.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.ClassPlans
{
    public class ClassPlanMap : EntityTypeConfiguration<ClassPlan>
    {
        public ClassPlanMap()
        {
            this.HasKey(k => k.ClassPlanId);
            this.HasMany(e => e.Chores)
                .WithRequired(e => e.ClassPlan)
                .WillCascadeOnDelete(false);
            this.HasMany(e => e.ClassGoals)
                .WithRequired(e => e.ClassPlan)
                .WillCascadeOnDelete(false);
            this.HasMany(e => e.LessonsContent)
                .WithRequired(e => e.ClassPlan)
                .WillCascadeOnDelete(false);
        }
    }
}
