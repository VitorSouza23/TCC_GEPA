using Gepa.Entities.Framework.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.Users
{
    public interface ITeacherDAO
    {
        void InsertTeacher(Teacher newTeacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(Teacher teacher);
        Teacher FindTeacher(long teacherId);
    }
}
