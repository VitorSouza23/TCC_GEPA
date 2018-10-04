using Gepa.Entities.Framework.Entities.ClassPlans;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.ClassPlans
{
    public class LessonsContentMap : EntityTypeConfiguration<LessonsContent>
    {
        public LessonsContentMap()
        {
            HasKey(k => k.LessonsContentId);
            HasRequired(k => k.ClassPlan)
                .WithMany(q => q.LessonsContents)
                .HasForeignKey(k => k.ClassPlanId)
                .WillCascadeOnDelete();
        }
    }
}
