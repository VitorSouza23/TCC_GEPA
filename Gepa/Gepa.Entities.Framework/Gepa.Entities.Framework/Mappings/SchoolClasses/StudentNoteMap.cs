using Gepa.Entities.Framework.Entities.SchoolClasses;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.SchoolClasses
{
    public class StudentNoteMap : EntityTypeConfiguration<StudentNote>
    {
        public StudentNoteMap()
        {
            HasKey(k => k.StudentNoteId);
            HasRequired(k => k.Student)
                .WithMany(b => b.StudentNotes)
                .HasForeignKey(k => k.StudentId)
                .WillCascadeOnDelete();
        }
    }
}
