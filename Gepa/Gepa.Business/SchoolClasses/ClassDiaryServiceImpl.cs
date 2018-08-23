using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.SchoolClasses;
using Gepa.Entities.Framework.Entities.SchoolClasses;

namespace Gepa.Business.SchoolClasses
{
    public class ClassDiaryServiceImpl : IClassDiaryService
    {
        private IClassDiaryDAO _classDiaryDAO;

        public ClassDiaryServiceImpl(IClassDiaryDAO classDiaryDAO)
        {
            _classDiaryDAO = classDiaryDAO;
        }

        public void DeleteClassDiary(ClassDiary classDiary)
        {
            _classDiaryDAO.DeleteClassDiary(classDiary);
        }

        public ClassDiary FindClassDiary(long classDiaryID)
        {
            return _classDiaryDAO.FindClassDiary(classDiaryID);
        }

        public void InsertClassDiary(ClassDiary newClassDiary)
        {
            _classDiaryDAO.InsertClassDiary(newClassDiary);
        }

        public void UpdateClassDiary(ClassDiary classDiary)
        {
            _classDiaryDAO.UpdateClassDiary(classDiary);
        }
    }
}
