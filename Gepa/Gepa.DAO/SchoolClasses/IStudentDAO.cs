using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.SchoolClasses
{
    public interface IStudentDAO
    {
        void InsertStudent(Student newStudent);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
        Student FindStudent(long studentId);
    }
}
