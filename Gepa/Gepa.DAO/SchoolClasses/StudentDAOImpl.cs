using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.SchoolClasses;

namespace Gepa.DAO.SchoolClasses
{
    public class StudentDAOImpl : AbstractDAO, IStudentDAO
    {
        public StudentDAOImpl(DbConnection dbConnectioOject) : base(dbConnectioOject)
        {
        }

        public void DeleteStudent(Student student)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Student.Remove(student);
                em.SaveChanges();
            }
        }

        public Student FindStudent(long studentId)
        {
            Student student = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                student = em.Student.Single(a => a.StudentId == studentId);
            }
            return student;
        }

        public void InsertStudent(Student newStudent)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Student.Add(newStudent);
                em.SaveChanges();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(student).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
