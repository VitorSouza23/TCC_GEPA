using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.Users;
using Gepa.Entities.Users;

namespace Gepa.Business.Users
{
    public class TeacherServiceImpl : ITeacherService
    {
        private ITeacherDAO _teacherDAO;

        public TeacherServiceImpl(ITeacherDAO teacherDAO)
        {
            _teacherDAO = teacherDAO;
        }

        public void DeleteTeacher(TeacherVO teacher)
        {
            _teacherDAO.DeleteTeacher(teacher);
        }

        public TeacherVO FindTeacher(long teacherId)
        {
            return _teacherDAO.FindTeacher(teacherId);
        }

        public void InsertTeacher(TeacherVO newTeacher)
        {
            _teacherDAO.InsertTeacher(newTeacher);
        }

        public void UpdateTeacher(TeacherVO teacher)
        {
            _teacherDAO.UpdateTeacher(teacher);
        }
    }
}
