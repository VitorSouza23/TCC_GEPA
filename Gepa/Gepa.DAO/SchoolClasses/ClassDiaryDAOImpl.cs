using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.SchoolClasses;

namespace Gepa.DAO.SchoolClasses
{
    public class ClassDiaryDAOImpl : AbstractDAO, IClassDiaryDAO
    {
        public ClassDiaryDAOImpl(DbConnection dbConnectioOject) : base(dbConnectioOject)
        {
        }

        public void DeleteClassDiary(ClassDiary classDiary)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.ClassDiary.Remove(classDiary);
                em.SaveChanges();
            }
        }

        public ClassDiary FindClassDiary(long classDiaryID)
        {
            ClassDiary classDiary = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                classDiary = em.ClassDiary.Find(classDiaryID);
            }
            return classDiary;
        }

        public async Task<ClassDiary> FindClassDiaryAsync(long classDiaryID)
        {
            ClassDiary classDiary = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                classDiary = await em.ClassDiary.FindAsync(classDiaryID);
            }
            return classDiary;
        }

        public void InsertClassDiary(ClassDiary newClassDiary)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.ClassDiary.Add(newClassDiary);
                em.SaveChanges();
            }
        }

        public void UpdateClassDiary(ClassDiary classDiary)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(classDiary).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
