using Gepa.Entities.Framework.Entities.ClassPlans;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.ClassPlans
{
    public class ChoresMap : EntityTypeConfiguration<Chores>
    {
        public ChoresMap()
        {
            HasKey(k => k.ChoresId);
            HasRequired(k => k.ClassPlan)
                .WithMany(p => p.Chores)
                .HasForeignKey(k => k.ClassPlanId)
                .WillCascadeOnDelete();
        }
    }
}
