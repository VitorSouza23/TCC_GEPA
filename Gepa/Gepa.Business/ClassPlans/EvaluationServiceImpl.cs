using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.ClassPlans;
using Gepa.Entities.ClassPlans;

namespace Gepa.Business.ClassPlans
{
    public class EvaluationServiceImpl : IEvaluationService
    {
        private IEvaluationDAO _evaluationDAO;

        public EvaluationServiceImpl(IEvaluationDAO evaluationDAO)
        {
            _evaluationDAO = evaluationDAO;
        }

        public void DeleteEvaluation(EvaluationVO evaluation)
        {
            _evaluationDAO.DeleteEvaluation(evaluation);
        }

        public EvaluationVO FindEvaluation(long evaluationId)
        {
            return _evaluationDAO.FindEvaluation(evaluationId);
        }

        public void InsertEvaluation(EvaluationVO newEvaluation)
        {
            _evaluationDAO.InsertEvaluation(newEvaluation);
        }

        public void UpdateEvaluation(EvaluationVO evaluation)
        {
            _evaluationDAO.UpdateEvaluation(evaluation);
        }
    }
}
