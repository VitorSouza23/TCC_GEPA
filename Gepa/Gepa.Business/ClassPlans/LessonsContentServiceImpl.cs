using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.ClassPlans;
using Gepa.Entities.ClassPlans;

namespace Gepa.Business.ClassPlans
{
    public class LessonsContentServiceImpl : ILessonsContentService
    {
        private ILessonsContentDAO _lessonsContentDAO;

        public LessonsContentServiceImpl(ILessonsContentDAO lessonsContentDAO)
        {
            _lessonsContentDAO = lessonsContentDAO;
        }

        public void DeleteLessonsContent(LessonContentVO lessonsContent)
        {
            _lessonsContentDAO.DeleteLessonsContent(lessonsContent);
        }

        public LessonContentVO FindLessonsContent(long lessonsContentId)
        {
            return _lessonsContentDAO.FindLessonsContent(lessonsContentId);
        }

        public void InsertLessonsContent(LessonContentVO newLessonsContent)
        {
            _lessonsContentDAO.InsertLessonsContent(newLessonsContent);
        }

        public void UpdateLessonsContent(LessonContentVO lessonsContent)
        {
            _lessonsContentDAO.UpdateLessonsContent(lessonsContent);
        }
    }
}
