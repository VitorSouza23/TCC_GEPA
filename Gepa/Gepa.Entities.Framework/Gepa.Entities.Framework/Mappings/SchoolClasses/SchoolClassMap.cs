using Gepa.Entities.Framework.Entities.SchoolClasses;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.SchoolClasses
{
    public class SchoolClassMap : EntityTypeConfiguration<SchoolClass>
    {
        public SchoolClassMap()
        {
            HasKey(k => k.SchoolClassId);
            HasRequired(k => k.School)
                .WithMany(q => q.SchoolClasses)
                .HasForeignKey(k => k.SchoolId)
                .WillCascadeOnDelete();
        }
    }
}
