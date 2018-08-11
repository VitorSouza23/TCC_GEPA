using Gepa.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.SchoolClasses
{
    public interface IStudentDAO
    {
        void InsertStudent(StudentVO newStudent);
        void UpdateStudent(StudentVO student);
        void DeleteStudent(StudentVO student);
        StudentVO FindStudent(long studentId);
    }
}
