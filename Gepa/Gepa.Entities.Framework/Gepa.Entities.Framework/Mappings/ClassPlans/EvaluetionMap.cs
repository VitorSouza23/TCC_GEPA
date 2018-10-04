using Gepa.Entities.Framework.Entities.ClassPlans;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.ClassPlans
{
    public class EvaluetionMap : EntityTypeConfiguration<Evaluetion>
    {
        public EvaluetionMap()
        {
            HasKey(k => k.EvaluetionId);
            HasRequired(k => k.ClassPlan)
                .WithMany(q => q.Evaluetions)
                .HasForeignKey(k => k.ClassPlanId)
                .WillCascadeOnDelete();
        }
    }
}
