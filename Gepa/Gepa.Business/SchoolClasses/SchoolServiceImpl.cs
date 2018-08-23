using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.SchoolClasses;
using Gepa.Entities.Framework.Entities.SchoolClasses;

namespace Gepa.Business.SchoolClasses
{
    public class SchoolServiceImpl : ISchoolService
    {
        private ISchoolDAO _schoolDAO;

        public SchoolServiceImpl(ISchoolDAO schoolDAO)
        {
            _schoolDAO = schoolDAO;
        }

        public void DeleteSchool(School school)
        {
            _schoolDAO.DeleteSchool(school);
        }

        public School FindStudent(long schoolId)
        {
            return _schoolDAO.FindStudent(schoolId);
        }

        public void InsertSchool(School newSchool)
        {
            _schoolDAO.InsertSchool(newSchool);
        }

        public void UpdateSchool(School school)
        {
            _schoolDAO.UpdateSchool(school);
        }
    }
}
