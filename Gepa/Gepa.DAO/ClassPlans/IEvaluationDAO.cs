﻿using Gepa.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.ClassPlans
{
    public interface IEvaluationDAO
    {
        void InsertEvaluation(EvaluationVO newEvaluation);
        void UpdateEvaluation(EvaluationVO evaluation);
        void DeleteEvaluation(EvaluationVO evaluation);
        EvaluationVO FindEvaluation(long evaluationId);
    }
}
