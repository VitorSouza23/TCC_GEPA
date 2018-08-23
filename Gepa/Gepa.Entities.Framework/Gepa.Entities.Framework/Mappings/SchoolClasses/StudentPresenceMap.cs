using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.SchoolClasses
{
    public class StudentPresenceMap : EntityTypeConfiguration<StudentPresence>
    {
        public StudentPresenceMap()
        {
            this.HasKey(k => k.StudentPresenceId);
        }
    }
}
