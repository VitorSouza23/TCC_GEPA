using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.SchoolClasses
{
    public class StudentNoteMap : EntityTypeConfiguration<StudentNote>
    {
        public StudentNoteMap()
        {
            this.HasKey(k => k.StudentNoteId);
        }
    }
}
