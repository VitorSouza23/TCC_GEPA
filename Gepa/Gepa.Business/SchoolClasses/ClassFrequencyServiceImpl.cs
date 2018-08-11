using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.SchoolClasses;
using Gepa.Entities.SchoolClasses;

namespace Gepa.Business.SchoolClasses
{
    public class ClassFrequencyServiceImpl : IClassFrequencyService
    {
        private IClassFrequencyDAO _classFrequencyDAO;

        public ClassFrequencyServiceImpl(IClassFrequencyDAO classFrequencyDAO)
        {
            _classFrequencyDAO = classFrequencyDAO;
        }

        public void DeleteClassFrequency(ClassFrequencyVO classFrequency)
        {
            _classFrequencyDAO.DeleteClassFrequency(classFrequency);
        }

        public ClassFrequencyVO FindClassFrequency(long classFrequencyId)
        {
            return _classFrequencyDAO.FindClassFrequency(classFrequencyId);
        }

        public void InsertClassFrequency(ClassFrequencyVO newClassFrequency)
        {
            _classFrequencyDAO.InsertClassFrequency(newClassFrequency);
        }

        public void UpdateClassFrequency(ClassFrequencyVO classFrequency)
        {
            _classFrequencyDAO.UpdateClassFrequency(classFrequency);
        }
    }
}
