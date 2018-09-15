using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.SchoolClasses;
using Gepa.Entities.Framework.Entities.SchoolClasses;

namespace Gepa.Business.SchoolClasses
{
    public class StudentServiceImpl : IStudentService
    {
        private IStudentDAO _studnetDAO;

        public StudentServiceImpl(IStudentDAO studnetDAO)
        {
            _studnetDAO = studnetDAO;
        }

        public void DeleteStudent(Student student)
        {
            _studnetDAO.DeleteStudent(student);
        }

        public Student FindStudent(long studentId)
        {
            return _studnetDAO.FindStudent(studentId);
        }

        public async Task<Student> FindStudentAsync(long studentId)
        {
            return await _studnetDAO.FindStudentAsync(studentId);
        }

        public void InsertStudent(Student newStudent)
        {
            _studnetDAO.InsertStudent(newStudent);
        }

        public void UpdateStudent(Student student)
        {
            _studnetDAO.UpdateStudent(student);
        }
    }
}
