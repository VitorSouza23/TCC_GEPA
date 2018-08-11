using Gepa.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.SchoolClasses
{
    public interface ISchoolClassService
    {
        void InserSchoolClass(SchoolClassVO newSchoolClass);
        void UpdateSchoolClass(SchoolClassVO schoolClass);
        void DeleteSchoolClass(SchoolClassVO schoolClass);
        SchoolClassVO FindSchoolClass(long schoolClassId);
    }
}
