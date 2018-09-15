using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.SchoolClasses
{
    public interface IClassFrequencyService : IGepaService
    {
        void InsertClassFrequency(ClassFrequency newClassFrequency);
        void UpdateClassFrequency(ClassFrequency classFrequency);
        void DeleteClassFrequency(ClassFrequency classFrequency);
        ClassFrequency FindClassFrequency(long classFrequencyId);
        Task<ClassFrequency> FindClassFrequencyAsync(long classFrequencyId);
    }
}
