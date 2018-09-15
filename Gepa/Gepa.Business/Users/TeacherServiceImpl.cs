using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.Users;
using Gepa.Entities.Framework.Entities.Users;

namespace Gepa.Business.Users
{
    public class TeacherServiceImpl : ITeacherService
    {
        private ITeacherDAO _teacherDAO;

        public TeacherServiceImpl(ITeacherDAO teacherDAO)
        {
            _teacherDAO = teacherDAO;
        }

        public void DeleteTeacher(Teacher teacher)
        {
            _teacherDAO.DeleteTeacher(teacher);
        }

        public Teacher FindTeacher(long teacherId)
        {
            return _teacherDAO.FindTeacher(teacherId);
        }

        public async Task<Teacher> FindTeacherAsync(long teacherId)
        {
            return await _teacherDAO.FindTeacherAsync(teacherId);
        }

        public void InsertTeacher(Teacher newTeacher)
        {
            _teacherDAO.InsertTeacher(newTeacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _teacherDAO.UpdateTeacher(teacher);
        }
    }
}
