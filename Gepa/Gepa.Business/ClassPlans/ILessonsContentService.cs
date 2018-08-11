using Gepa.DAO.ClassPlans;
using Gepa.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.ClassPlans
{
    public interface ILessonsContentService
    {
        void InsertLessonsContent(LessonContentVO newLessonsContent);
        void UpdateLessonsContent(LessonContentVO lessonsContent);
        void DeleteLessonsContent(LessonContentVO lessonsContent);
        LessonContentVO FindLessonsContent(long lessonsContentId);
    }
}
