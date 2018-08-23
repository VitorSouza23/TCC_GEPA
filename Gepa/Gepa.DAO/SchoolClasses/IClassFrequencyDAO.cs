using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.SchoolClasses
{
    public interface IClassFrequencyDAO
    {
        void InsertClassFrequency(ClassFrequency newClassFrequency);
        void UpdateClassFrequency(ClassFrequency classFrequency);
        void DeleteClassFrequency(ClassFrequency classFrequency);
        ClassFrequency FindClassFrequency(long classFrequencyId);
    }
}
