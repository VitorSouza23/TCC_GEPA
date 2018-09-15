﻿using Gepa.Entities.Framework.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.ClassPlans
{
    public interface IEvaluationService : IGepaService
    {
        void InsertEvaluation(Evaluetion newEvaluation);
        void UpdateEvaluation(Evaluetion evaluation);
        void DeleteEvaluation(Evaluetion evaluation);
        Evaluetion FindEvaluation(long evaluationId);
        Task<Evaluetion> FindEvaluationAsync(long evaluationId);
    }
}
