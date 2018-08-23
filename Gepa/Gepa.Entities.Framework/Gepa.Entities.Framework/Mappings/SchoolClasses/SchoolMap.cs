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
            this.HasKey(k => k.SchoolId);
            this.HasMany(e => e.SchoolClass)
                .WithRequired(e => e.School)
                .WillCascadeOnDelete(false);
        }
    }
}
