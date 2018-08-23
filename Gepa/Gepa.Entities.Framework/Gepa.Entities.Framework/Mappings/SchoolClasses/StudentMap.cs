using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.SchoolClasses
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            this.HasKey(k => k.StudentId);
            this.HasMany(e => e.StudentNote)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
            this.HasMany(e => e.StudentPresence)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
