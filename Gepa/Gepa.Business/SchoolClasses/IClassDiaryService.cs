using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.SchoolClasses
{
    public interface IClassDiaryService : IGepaService
    {
        void InsertClassDiary(ClassDiary newClassDiary);
        void UpdateClassDiary(ClassDiary classDiary);
        void DeleteClassDiary(ClassDiary classDiary);
        ClassDiary FindClassDiary(long classDiaryID);
        Task<ClassDiary> FindClassDiaryAsync(long classDiaryID);
    }
}
