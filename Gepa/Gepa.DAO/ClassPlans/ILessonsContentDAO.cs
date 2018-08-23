using Gepa.Entities.Framework.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.ClassPlans
{
    public interface ILessonsContentDAO
    {
        void InsertLessonsContent(LessonsContent newLessonsContent);
        void UpdateLessonsContent(LessonsContent lessonsContent);
        void DeleteLessonsContent(LessonsContent lessonsContent);
        LessonsContent FindLessonsContent(long lessonsContentId);
    }
}
