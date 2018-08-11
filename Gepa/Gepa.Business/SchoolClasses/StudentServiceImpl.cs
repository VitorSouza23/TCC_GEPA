using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.SchoolClasses;
using Gepa.Entities.SchoolClasses;

namespace Gepa.Business.SchoolClasses
{
    public class StudentServiceImpl : IStudentService
    {
        private IStudentDAO _studnetDAO;

        public StudentServiceImpl(IStudentDAO studnetDAO)
        {
            _studnetDAO = studnetDAO;
        }

        public void DeleteStudent(StudentVO student)
        {
            _studnetDAO.DeleteStudent(student);
        }

        public StudentVO FindStudent(long studentId)
        {
            return _studnetDAO.FindStudent(studentId);
        }

        public void InsertStudent(StudentVO newStudent)
        {
            _studnetDAO.InsertStudent(newStudent);
        }

        public void UpdateStudent(StudentVO student)
        {
            _studnetDAO.UpdateStudent(student);
        }
    }
}
