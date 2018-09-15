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
    public class StudentNoteDAOImpl : AbstractDAO, IStudentNoteDAO
    {
        public StudentNoteDAOImpl(DbConnection dbConnectioOject) : base(dbConnectioOject)
        {
        }

        public void DeleteStudentNote(StudentNote studentNote)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.StudentNote.Remove(studentNote);
                em.SaveChanges();
            }
        }

        public StudentNote FindStudentNote(long studentNoteId)
        {
            StudentNote studentNote = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                studentNote = em.StudentNote.Find(studentNoteId);
            }
            return studentNote;
        }

        public async Task<StudentNote> FindStudentNoteAsync(long studentNoteId)
        {
            StudentNote studentNote = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                studentNote = await em.StudentNote.FindAsync(studentNoteId);
            }
            return studentNote;
        }

        public void InsertStudentNote(StudentNote newStudentNote)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.StudentNote.Add(newStudentNote);
                em.SaveChanges();
            }
        }

        public void UpdateStudentNote(StudentNote studentNote)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(studentNote).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
