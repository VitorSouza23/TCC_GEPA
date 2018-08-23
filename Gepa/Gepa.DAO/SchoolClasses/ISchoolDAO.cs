using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.SchoolClasses
{
    public interface ISchoolDAO
    {
        void InsertSchool(School newSchool);
        void UpdateSchool(School school);
        void DeleteSchool(School school);
        School FindStudent(long schoolId);
    }
}
