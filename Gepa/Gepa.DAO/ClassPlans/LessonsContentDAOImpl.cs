using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.ClassPlans
{
    public class LessonsContentDAOImpl : AbstractDAO, ILessonsContentDAO
    {
        public LessonsContentDAOImpl() : base()
        {
        }

        public void DeleteLessonsContent(LessonsContent lessonsContent)
        {
            using (EntityModel em = new EntityModel())
            {
                em.LessonsContent.Remove(lessonsContent);
                em.SaveChanges();
            }
        }

        public LessonsContent FindLessonsContent(long lessonsContentId)
        {
            LessonsContent lessonsContent = null;
            using (EntityModel em = new EntityModel())
            {
                lessonsContent = em.LessonsContent.Find(lessonsContentId);
            }
            return lessonsContent;
        }

        public async Task<LessonsContent> FindLessonsContentAsync(long lessonsContentId)
        {
            LessonsContent lessonsContent = null;
            using (EntityModel em = new EntityModel())
            {
                lessonsContent = await em.LessonsContent.FindAsync(lessonsContentId);
            }
            return lessonsContent;
        }

        public void InsertLessonsContent(LessonsContent newLessonsContent)
        {
            using (EntityModel em = new EntityModel())
            {
                em.LessonsContent.Add(newLessonsContent);
                em.SaveChanges();
            }
        }

        public void UpdateLessonsContent(LessonsContent lessonsContent)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Entry(lessonsContent).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
