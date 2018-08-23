using Gepa.Entities.Framework.Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Entities.Framework.Mappings.Accounts
{
    public class AdminAccountMap : EntityTypeConfiguration<AdminAccount>
    {
        public AdminAccountMap()
        {
            this.HasKey(k => k.AccountId);
        }
    }
}
