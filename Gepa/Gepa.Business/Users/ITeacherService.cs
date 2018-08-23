using Gepa.Entities.Framework.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.Users
{
    public interface ITeacherService : IGepaService
    {
        void InsertTeacher(Teacher newTeacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(Teacher teacher);
        Teacher FindTeacher(long teacherId);
    }
}
