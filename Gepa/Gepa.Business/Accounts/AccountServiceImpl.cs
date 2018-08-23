using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.Accounts;
using Gepa.Entities.Framework.Entities.Accounts;

namespace Gepa.Business.Accounts
{
    public class AccountServiceImpl : IAccountService
    {
        private IAccountDAO _accountDAO;

        public AccountServiceImpl(IAccountDAO accountDAO)
        {
            _accountDAO = accountDAO;
        }

        public void DeleteAcccount(Account account)
        {
            _accountDAO.DeleteAcccount(account);
        }

        public Account FindAccount(long accountId)
        {
            return _accountDAO.FindAccount(accountId);
        }

        public void InsertAccount(Account newAccount)
        {
            _accountDAO.InsertAccount(newAccount);
        }

        public void UpateAccount(Account account)
        {
            _accountDAO.UpateAccount(account);
        }

        public void InsertTeacherAccount(TeacherAccount newTeacherAccount)
        {
            _accountDAO.InsertTeacherAccount(newTeacherAccount);
        }

        public void UpdaeTeacherAccount(TeacherAccount teacherAccount)
        {
            _accountDAO.UpdaeTeacherAccount(teacherAccount);
        }

        public void DeleteTeacherAccount(TeacherAccount teacherAccount)
        {
            _accountDAO.DeleteTeacherAccount(teacherAccount);
        }

        public TeacherAccount FindTeacherAccount(long teacherAccountId)
        {
            return _accountDAO.FindTeacherAccount(teacherAccountId);
        }
    }
}
