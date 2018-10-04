using Gepa.Entities.Framework.Entities.ClassPlans;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.ClassPlans
{
    public class ClassGoalsMap : EntityTypeConfiguration<ClassGoals>
    {
        public ClassGoalsMap()
        {
            HasKey(k => k.ClassGoalsId);
            HasRequired(k => k.ClassPlan)
                .WithMany(b => b.ClassGoals)
                .HasForeignKey(k => k.ClassPlanId)
                .WillCascadeOnDelete();
        }
    }
}
