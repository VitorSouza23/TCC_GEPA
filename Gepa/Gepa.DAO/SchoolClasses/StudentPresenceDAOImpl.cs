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
    public class StudentPresenceDAOImpl : AbstractDAO, IStudentPresenceDAO
    {
        public StudentPresenceDAOImpl() : base()
        {
        }

        public void DeleteStudentPresense(StudentPresence studentPresence)
        {
            using (EntityModel em = new EntityModel())
            {
                em.StudentPresence.Remove(studentPresence);
                em.SaveChanges();
            }
        }

        public StudentPresence FindStudentPresnece(long studentPresenceID)
        {
            StudentPresence studentPresence = null;
            using (EntityModel em = new EntityModel())
            {
                studentPresence = em.StudentPresence.Find(studentPresenceID);
            }
            return studentPresence;
        }

        public async Task<StudentPresence> FindStudentPresneceAsync(long studentPresenceID)
        {
            StudentPresence studentPresence = null;
            using (EntityModel em = new EntityModel())
            {
                studentPresence = await em.StudentPresence.FindAsync(studentPresenceID);
            }
            return studentPresence;
        }

        public void InsertStudentPresence(StudentPresence newStudentPresnece)
        {
            using (EntityModel em = new EntityModel())
            {
                em.StudentPresence.Add(newStudentPresnece);
                em.SaveChanges();
            }
        }

        public void UpdateStudentPresence(StudentPresence studentPresnece)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Entry(studentPresnece).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
