﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.SchoolClasses;

namespace Gepa.DAO.SchoolClasses
{
    public class ClassFrequencyDAOImpl : AbstractDAO, IClassFrequencyDAO
    {
        public ClassFrequencyDAOImpl(DbConnection dbConnectioOject) : base(dbConnectioOject)
        {
        }

        public void DeleteClassFrequency(ClassFrequency classFrequency)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.ClassFrequency.Remove(classFrequency);
                em.SaveChanges();
            }
        }

        public ClassFrequency FindClassFrequency(long classFrequencyId)
        {
            ClassFrequency classFrequency = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                classFrequency = em.ClassFrequency.Find(classFrequencyId);
            }
            return classFrequency;
        }

        public async Task<ClassFrequency> FindClassFrequencyAsync(long classFrequencyId)
        {
            ClassFrequency classFrequency = null;
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                classFrequency = await em.ClassFrequency.FindAsync(classFrequencyId);
            }
            return classFrequency;
        }

        public void InsertClassFrequency(ClassFrequency newClassFrequency)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.ClassFrequency.Add(newClassFrequency);
                em.SaveChanges();
            }
        }

        public void UpdateClassFrequency(ClassFrequency classFrequency)
        {
            using (EntityModel em = new EntityModel(DbConnectioOject))
            {
                em.Entry(classFrequency).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
