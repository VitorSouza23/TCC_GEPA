using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.Users;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Gepa.DAO.Users
{
    public class TeacherDAOImpl : AbstractDAO, ITeacherDAO
    {
        public TeacherDAOImpl() : base()
        {
        }

        public void DeleteTeacher(Teacher teacher)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Teacher.Remove(teacher);
                em.SaveChanges();
            }
        }

        public Teacher FindTeacher(long teacherId)
        {
            Teacher teacher = null;
            using (EntityModel em = new EntityModel())
            {
                teacher = em.Teacher.Find(teacherId);
            }
            return teacher;
        }

        public async Task<Teacher> FindTeacherAsync(long teacherId)
        {
            Teacher teacher = null;
            using (EntityModel em = new EntityModel())
            {
                teacher = await em.Teacher.FindAsync(teacherId);
            }
            return teacher;
        }

        public void InsertTeacher(Teacher newTeacher)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Teacher.Add(newTeacher);
                em.SaveChanges();
            }
        }

        public void UpdateTeacher(Teacher teacher)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Entry(teacher).State = EntityState.Modified;
                em.SaveChanges();
            }
        }

        public async Task<Teacher> FindTeacherByUserIdAsync(string userId)
        {
            Teacher teacher = null;
            using (EntityModel em = new EntityModel())
            {
                teacher = await em.Teacher.SingleAsync(t => t.UserId == userId);
            }
            return teacher;
        }
    }
}
