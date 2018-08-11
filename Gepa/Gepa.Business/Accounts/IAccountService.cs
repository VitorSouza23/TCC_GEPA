﻿using Gepa.Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.Accounts
{
    public interface IAccountService
    {
        void InsertAccount(AccountVO newAccount);
        void UpateAccount(AccountVO account);
        void DeleteAcccount(AccountVO account);
        AccountVO FindAccount(long accountId);
    }
}
