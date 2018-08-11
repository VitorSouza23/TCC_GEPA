using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.Accounts;
using Gepa.Entities.Accounts;

namespace Gepa.Business.Accounts
{
    public class AccountServiceImpl : IAccountService
    {
        private IAccountDAO _accountDAO;

        public AccountServiceImpl(IAccountDAO accountDAO)
        {
            _accountDAO = accountDAO;
        }

        public void DeleteAcccount(AccountVO account)
        {
            _accountDAO.DeleteAcccount(account);
        }

        public AccountVO FindAccount(long accountId)
        {
            return _accountDAO.FindAccount(accountId);
        }

        public void InsertAccount(AccountVO newAccount)
        {
            _accountDAO.InsertAccount(newAccount);
        }

        public void UpateAccount(AccountVO account)
        {
            _accountDAO.UpateAccount(account);
        }
    }
}
