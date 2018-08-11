using Gepa.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.SchoolClasses
{
    public interface IStudentService
    {
        void InsertStudent(StudentVO newStudent);
        void UpdateStudent(StudentVO student);
        void DeleteStudent(StudentVO student);
        StudentVO FindStudent(long studentId);
    }
}
