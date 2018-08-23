using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.Accounts;

namespace Gepa.DAO.Accounts
{
    public class AccountDAOImpl : AbstractDAO, IAccountDAO
    {
        public AccountDAOImpl(DbConnection dbConnectioOject) : base(dbConnectioOject)
        {
        }

        public void DeleteAcccount(Account account)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Account.Remove(account);
                em.SaveChanges();
            }
        }

        public void InsertAccount(Account newAccount)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Account.Add(newAccount);
                em.SaveChanges();
            }
        }

        public void UpateAccount(Account account)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(account).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }

        public Account FindAccount(long accountId)
        {
            Account account = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                account = em.Account.Single(a => a.AccountId == accountId);
            }
            return account;
        }

        public void InsertTeacherAccount(TeacherAccount newTeacherAccount)
        {
            using(EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Account.Add(newTeacherAccount);
                em.SaveChanges();
            }
        }

        public void UpdaeTeacherAccount(TeacherAccount teacherAccount)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(teacherAccount).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }

        public void DeleteTeacherAccount(TeacherAccount teacherAccount)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Account.Remove(teacherAccount);
                em.SaveChanges();
            }
        }

        public TeacherAccount FindTeacherAccount(long teacherAccountId)
        {
            TeacherAccount teacherAccount = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                teacherAccount = (TeacherAccount)em.Account.Single(a => a.AccountId == teacherAccountId);
            }
            return teacherAccount;
        }
    }
}
