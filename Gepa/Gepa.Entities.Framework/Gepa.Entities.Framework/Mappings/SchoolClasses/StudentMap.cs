using Gepa.Entities.Framework.Entities.SchoolClasses;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.SchoolClasses
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            HasKey(k => k.StudentId);
            HasRequired(k => k.SchoolClass)
                .WithMany(b => b.Students)
                .HasForeignKey(k => k.SchoolClassId)
                .WillCascadeOnDelete();
        }
    }
}
