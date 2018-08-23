using Gepa.Entities.Framework.Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.Accounts
{
    public interface IAccountDAO
    {
        void InsertAccount(Account newAccount);
        void UpateAccount(Account account);
        void DeleteAcccount(Account account);
        Account FindAccount(long accountId);
        void InsertTeacherAccount(TeacherAccount newTeacherAccount);
        void UpdaeTeacherAccount(TeacherAccount teacherAccount);
        void DeleteTeacherAccount(TeacherAccount teacherAccount);
        TeacherAccount FindTeacherAccount(long teacherAccountId);
    }
}
