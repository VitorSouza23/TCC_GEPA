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
        public StudentDAOImpl() : base()
        {
        }

        public void DeleteStudent(Student student)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Student.Remove(student);
                em.SaveChanges();
            }
        }

        public Student FindStudent(long studentId)
        {
            Student student = null;
            using (EntityModel em = new EntityModel())
            {
                student = em.Student.Find(studentId);
            }
            return student;
        }

        public async Task<Student> FindStudentAsync(long studentId)
        {
            Student student = null;
            using (EntityModel em = new EntityModel())
            {
                student = await em.Student.FindAsync(studentId);
            }
            return student;
        }

        public void InsertStudent(Student newStudent)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Student.Add(newStudent);
                em.SaveChanges();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Entry(student).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
