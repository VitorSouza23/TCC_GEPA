using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.Entities.SchoolClasses;
using Gepa.DAO.SchoolClasses;

namespace Gepa.Business.SchoolClasses
{
    public class StudnetNoteServiceImpl : IStudentNoteService
    {
        private IStudentNoteDAO _studentNoteDAO;

        public StudnetNoteServiceImpl(IStudentNoteDAO studentNoteDAO)
        {
            _studentNoteDAO = studentNoteDAO;
        }

        public void DeleteStudentNote(StudentNoteVO studentNote)
        {
            _studentNoteDAO.DeleteStudentNote(studentNote);
        }

        public StudentNoteVO FindStudentNote(long studentNoteId)
        {
            return _studentNoteDAO.FindStudentNote(studentNoteId);
        }

        public void InsertStudentNote(StudentNoteVO newStudentNote)
        {
            _studentNoteDAO.InsertStudentNote(newStudentNote);
        }

        public void UpdateStudentNote(StudentNoteVO studentNote)
        {
            _studentNoteDAO.UpdateStudentNote(studentNote);
        }
    }
}
