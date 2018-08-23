using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.SchoolClasses
{
    public interface ISchoolClassService : IGepaService
    {
        void InserSchoolClass(SchoolClass newSchoolClass);
        void UpdateSchoolClass(SchoolClass schoolClass);
        void DeleteSchoolClass(SchoolClass schoolClass);
        SchoolClass FindSchoolClass(long schoolClassId);
    }
}
