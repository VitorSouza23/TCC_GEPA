using Gepa.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.SchoolClasses
{
    public interface IClassDiaryDAO
    {
        void InsertClassDiary(ClassDiaryVO newClassDiary);
        void UpdateClassDiary(ClassDiaryVO classDiary);
        void DeleteClassDiary(ClassDiaryVO classDiary);
        ClassDiaryVO FindClassDiary(long classDiaryID);
    }
}
