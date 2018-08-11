using Gepa.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.Users
{
    public interface ITeacherDAO
    {
        void InsertTeacher(TeacherVO newTeacher);
        void UpdateTeacher(TeacherVO teacher);
        void DeleteTeacher(TeacherVO teacher);
        TeacherVO FindTeacher(long teacherId);
    }
}
