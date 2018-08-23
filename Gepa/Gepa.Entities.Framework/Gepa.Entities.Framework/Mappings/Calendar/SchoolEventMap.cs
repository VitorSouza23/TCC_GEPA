﻿using Gepa.Entities.Framework.Entities.Calendar;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.Calendar
{
    public class SchoolEventMap : EntityTypeConfiguration<SchoolEvent>
    {
        public SchoolEventMap()
        {
            this.HasKey(k => k.AbstractSchoolEventId);
        }
    }
}
