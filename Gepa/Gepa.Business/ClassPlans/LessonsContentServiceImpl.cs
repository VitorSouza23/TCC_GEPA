using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.ClassPlans;
using Gepa.Entities.Framework.Entities.ClassPlans;

namespace Gepa.Business.ClassPlans
{
    public class LessonsContentServiceImpl : ILessonsContentService
    {
        private ILessonsContentDAO _lessonsContentDAO;

        public LessonsContentServiceImpl(ILessonsContentDAO lessonsContentDAO)
        {
            _lessonsContentDAO = lessonsContentDAO;
        }

        public void DeleteLessonsContent(LessonsContent lessonsContent)
        {
            _lessonsContentDAO.DeleteLessonsContent(lessonsContent);
        }

        public LessonsContent FindLessonsContent(long lessonsContentId)
        {
            return _lessonsContentDAO.FindLessonsContent(lessonsContentId);
        }

        public async Task<LessonsContent> FindLessonsContentAsync(long lessonsContentId)
        {
            return await _lessonsContentDAO.FindLessonsContentAsync(lessonsContentId);
        }

        public void InsertLessonsContent(LessonsContent newLessonsContent)
        {
            _lessonsContentDAO.InsertLessonsContent(newLessonsContent);
        }

        public void UpdateLessonsContent(LessonsContent lessonsContent)
        {
            _lessonsContentDAO.UpdateLessonsContent(lessonsContent);
        }
    }
}
