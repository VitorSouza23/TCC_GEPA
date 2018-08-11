using Gepa.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.SchoolClasses
{
    public interface IClassFrequencyDAO
    {
        void InsertClassFrequency(ClassFrequencyVO newClassFrequency);
        void UpdateClassFrequency(ClassFrequencyVO classFrequency);
        void DeleteClassFrequency(ClassFrequencyVO classFrequency);
        ClassFrequencyVO FindClassFrequency(long classFrequencyId);
    }
}
