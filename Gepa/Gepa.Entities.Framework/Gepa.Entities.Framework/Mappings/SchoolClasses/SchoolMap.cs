using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.SchoolClasses
{
    public class SchoolMap : EntityTypeConfiguration<School>
    {
        public SchoolMap()
        {
            HasKey(k => k.SchoolId);
            HasRequired(k => k.Teacher)
                .WithMany(q => q.School)
                .HasForeignKey(k => k.TeacherId)
                .WillCascadeOnDelete();
        }
    }
}
