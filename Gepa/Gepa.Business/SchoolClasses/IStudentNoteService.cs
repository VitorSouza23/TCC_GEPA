using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.SchoolClasses
{
    public interface IStudentNoteService : IGepaService
    {
        void InsertStudentNote(StudentNote newStudentNote);
        void UpdateStudentNote(StudentNote studentNote);
        void DeleteStudentNote(StudentNote studentNote);
        StudentNote FindStudentNote(long studentNoteId);
        Task<StudentNote> FindStudentNoteAsync(long studentNoteId);
    }
}
