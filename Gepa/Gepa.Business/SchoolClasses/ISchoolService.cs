using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Business.SchoolClasses
{
    public interface ISchoolService : IGepaService
    {
        void InsertSchool(School newSchool);
        void UpdateSchool(School school);
        void DeleteSchool(School school);
        School FindStudent(long schoolId);
        Task<School> FindStudentAsync(long schoolId);
    }
}
