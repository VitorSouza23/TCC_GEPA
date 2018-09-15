using Gepa.Entities.Framework.Entities.ClassPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.ClassPlans
{
    public interface IEvaluationDAO
    {
        void InsertEvaluation(Evaluetion newEvaluation);
        void UpdateEvaluation(Evaluetion evaluation);
        void DeleteEvaluation(Evaluetion evaluation);
        Evaluetion FindEvaluation(long evaluationId);
        Task<Evaluetion> FindEvaluationAsync(long evaluationId);
    }
}
