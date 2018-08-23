using Gepa.Entities.Framework.Entities.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.Users
{
    public class TeacherMap : EntityTypeConfiguration<Teacher>
    {
        public TeacherMap()
        {
            this.HasKey(k => k.TeacherId);
            this.HasMany(e => e.ClassPlan)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);
            this.HasMany(e => e.School)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);
            this.HasMany(e => e.SchoolCalendar)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);
            this.HasMany(e => e.SchoolClass)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);
        }
    }
}
