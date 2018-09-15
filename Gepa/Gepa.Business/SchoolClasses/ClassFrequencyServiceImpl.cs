using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.SchoolClasses;
using Gepa.Entities.Framework.Entities.SchoolClasses;

namespace Gepa.Business.SchoolClasses
{
    public class ClassFrequencyServiceImpl : IClassFrequencyService
    {
        private IClassFrequencyDAO _classFrequencyDAO;

        public ClassFrequencyServiceImpl(IClassFrequencyDAO classFrequencyDAO)
        {
            _classFrequencyDAO = classFrequencyDAO;
        }

        public void DeleteClassFrequency(ClassFrequency classFrequency)
        {
            _classFrequencyDAO.DeleteClassFrequency(classFrequency);
        }

        public ClassFrequency FindClassFrequency(long classFrequencyId)
        {
            return _classFrequencyDAO.FindClassFrequency(classFrequencyId);
        }

        public async Task<ClassFrequency> FindClassFrequencyAsync(long classFrequencyId)
        {
            return await _classFrequencyDAO.FindClassFrequencyAsync(classFrequencyId);
        }

        public void InsertClassFrequency(ClassFrequency newClassFrequency)
        {
            _classFrequencyDAO.InsertClassFrequency(newClassFrequency);
        }

        public void UpdateClassFrequency(ClassFrequency classFrequency)
        {
            _classFrequencyDAO.UpdateClassFrequency(classFrequency);
        }
    }
}
