using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.SchoolClasses
{
    public class ClassFrequencyMap : EntityTypeConfiguration<ClassFrequency>
    {
        public ClassFrequencyMap()
        {
            this.HasKey(k => k.ClassFrequencyId);
            this.HasMany(e => e.StudentPresence)
                .WithRequired(e => e.ClassFrequency)
                .WillCascadeOnDelete(false);
        }
    }
}
