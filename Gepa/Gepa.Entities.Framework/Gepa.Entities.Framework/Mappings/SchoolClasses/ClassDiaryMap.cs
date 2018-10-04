using Gepa.Entities.Framework.Entities.SchoolClasses;
using System.Data.Entity.ModelConfiguration;

namespace Gepa.Entities.Framework.Mappings.SchoolClasses
{
    public class ClassDiaryMap : EntityTypeConfiguration<ClassDiary>
    {
        public ClassDiaryMap()
        {
            HasKey(k => k.ClassDiaryId);
            HasRequired(k => k.SchoolClass)
                .WithMany(q => q.ClassDiary)
                .HasForeignKey(k => k.SchoolClassId)
                .WillCascadeOnDelete();
        }
    }
}
