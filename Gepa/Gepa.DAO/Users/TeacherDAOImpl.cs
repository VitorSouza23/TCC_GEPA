using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.Users;

namespace Gepa.DAO.Users
{
    public class TeacherDAOImpl : AbstractDAO, ITeacherDAO
    {
        public TeacherDAOImpl(DbConnection dbConnectioOject) : base(dbConnectioOject)
        {
        }

        public void DeleteTeacher(Teacher teacher)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Teacher.Remove(teacher);
                em.SaveChanges();
            }
        }

        public Teacher FindTeacher(long teacherId)
        {
            Teacher teacher = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                teacher = em.Teacher.Single(a => a.TeacherId == teacherId);
            }
            return teacher;
        }

        public void InsertTeacher(Teacher newTeacher)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Teacher.Add(newTeacher);
                em.SaveChanges();
            }
        }

        public void UpdateTeacher(Teacher teacher)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
