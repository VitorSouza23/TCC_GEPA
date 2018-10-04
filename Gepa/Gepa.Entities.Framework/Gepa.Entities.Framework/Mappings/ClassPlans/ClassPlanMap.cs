using Gepa.Entities.Framework.Entities.ClassPlans;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.ClassPlans
{
    public class ClassPlanMap : EntityTypeConfiguration<ClassPlan>
    {
        public ClassPlanMap()
        {
            HasKey(k => k.ClassPlanId);
            HasRequired(k => k.Teacher)
                .WithMany(b => b.ClassPlan)
                .HasForeignKey(k => k.TeacherId)
                .WillCascadeOnDelete();
        }
    }
}
