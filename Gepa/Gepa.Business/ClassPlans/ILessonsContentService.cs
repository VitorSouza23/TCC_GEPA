using Gepa.DAO.ClassPlans;
using Gepa.Entities.Framework.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.ClassPlans
{
    public interface ILessonsContentService : IGepaService
    {
        void InsertLessonsContent(LessonsContent newLessonsContent);
        void UpdateLessonsContent(LessonsContent lessonsContent);
        void DeleteLessonsContent(LessonsContent lessonsContent);
        LessonsContent FindLessonsContent(long lessonsContentId);
    }
}
