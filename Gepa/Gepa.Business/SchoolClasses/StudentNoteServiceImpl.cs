using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.SchoolClasses;
using Gepa.Entities.Framework.Entities.SchoolClasses;

namespace Gepa.Business.SchoolClasses
{
    public class StudentNoteServiceImpl : IStudentNoteService
    {
        private IStudentNoteDAO _studentNoteDAO;

        public StudentNoteServiceImpl(IStudentNoteDAO studentNoteDAO)
        {
            _studentNoteDAO = studentNoteDAO;
        }

        public void DeleteStudentNote(StudentNote studentNote)
        {
            _studentNoteDAO.DeleteStudentNote(studentNote);
        }

        public StudentNote FindStudentNote(long studentNoteId)
        {
            return _studentNoteDAO.FindStudentNote(studentNoteId);
        }

        public void InsertStudentNote(StudentNote newStudentNote)
        {
            _studentNoteDAO.InsertStudentNote(newStudentNote);
        }

        public void UpdateStudentNote(StudentNote studentNote)
        {
            _studentNoteDAO.UpdateStudentNote(studentNote);
        }
    }
}
