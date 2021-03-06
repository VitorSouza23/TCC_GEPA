﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.Entities.Framework;
using Gepa.Entities.Framework.Entities.ClassPlans;

namespace Gepa.DAO.ClassPlans
{
    public class EvaluationDAOImpl : AbstractDAO, IEvaluationDAO
    {
        public EvaluationDAOImpl() : base()
        {
        }

        public void DeleteEvaluation(Evaluetion evaluation)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Evaluetion.Remove(evaluation);
                em.SaveChanges();
            }
        }

        public Evaluetion FindEvaluation(long evaluationId)
        {
            Evaluetion evaluetion = null;
            using (EntityModel em = new EntityModel())
            {
                evaluetion = em.Evaluetion.Find(evaluationId);
            }
            return evaluetion;
        }

        public async Task<Evaluetion> FindEvaluationAsync(long evaluationId)
        {
            Evaluetion evaluetion = null;
            using (EntityModel em = new EntityModel())
            {
                evaluetion = await em.Evaluetion.FindAsync(evaluationId);
            }
            return evaluetion;
        }

        public void InsertEvaluation(Evaluetion newEvaluation)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Evaluetion.Add(newEvaluation);
                em.SaveChanges();
            }
        }

        public void UpdateEvaluation(Evaluetion evaluation)
        {
            using (EntityModel em = new EntityModel())
            {
                em.Entry(evaluation).State = System.Data.Entity.EntityState.Modified;
                em.SaveChanges();
            }
        }
    }
}
