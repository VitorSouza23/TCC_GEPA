using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.ClassPlans
{
    public interface ILessonsContentDAO
    {
        void InsertLessonsContent(LessonsContetVO newLessonsContent);
        void UpdateLessonsContent(LessonsContetVO lessonsContet);
        void DeleteLessonsContent(LessonsContetVO lessonsContet);
        LessonsContetVO FindLessonsContent(long lessonsContentId);
    }
}
