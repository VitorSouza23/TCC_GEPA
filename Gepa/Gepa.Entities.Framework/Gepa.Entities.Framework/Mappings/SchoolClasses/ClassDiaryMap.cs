using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.SchoolClasses
{
    public class ClassDiaryMap : EntityTypeConfiguration<ClassDiary>
    {
        public ClassDiaryMap()
        {
            this.HasKey(k => k.ClassDiaryId);
            this.HasMany(e => e.StudentNote)
                .WithRequired(e => e.ClassDiary)
                .WillCascadeOnDelete(false);
        }
    }
}
