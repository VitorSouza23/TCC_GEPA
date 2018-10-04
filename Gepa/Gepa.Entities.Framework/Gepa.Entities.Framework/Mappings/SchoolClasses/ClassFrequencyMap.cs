using Gepa.Entities.Framework.Entities.SchoolClasses;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.SchoolClasses
{
    public class ClassFrequencyMap : EntityTypeConfiguration<ClassFrequency>
    {
        public ClassFrequencyMap()
        {
            HasKey(k => k.ClassFrequencyId);
            HasRequired(k => k.SchoolClass)
                .WithMany(q => q.ClassFrequency)
                .HasForeignKey(k => k.SchoolClassId)
                .WillCascadeOnDelete();
        }
    }
}
