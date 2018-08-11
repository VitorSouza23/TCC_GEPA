﻿using Gepa.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.SchoolClasses
{
    interface IStudentNoteDAO
    {
        void InsertStudentNote(StudentNoteVO newStudentNote);
        void UpdateStudentNote(StudentNoteVO studentNote);
        void DeleteStudentNote(StudentNoteVO studentNote);
        StudentNoteVO FindStudentNote(long studentNoteId);
    }
}
