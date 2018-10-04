using Gepa.Entities.Framework.Entities.SchoolClasses;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.SchoolClasses
{
    public class StudentPresenceMap : EntityTypeConfiguration<StudentPresence>
    {
        public StudentPresenceMap()
        {
            HasKey(k => k.StudentPresenceId);
            HasRequired(k => k.Student)
                .WithMany(b => b.StudentPresences)
                .HasForeignKey(k => k.StudentId)
                .WillCascadeOnDelete();
        }
    }
}
