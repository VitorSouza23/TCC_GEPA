using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.SchoolClasses;
using Gepa.Entities.SchoolClasses;

namespace Gepa.Business.SchoolClasses
{
    public class SchoolClassServiceImpl : ISchoolClassService
    {
        private ISchoolClassDAO _schoolClassDAO;

        public SchoolClassServiceImpl(ISchoolClassDAO schoolClassDAO)
        {
            _schoolClassDAO = schoolClassDAO;
        }

        public void DeleteSchoolClass(SchoolClassVO schoolClass)
        {
            _schoolClassDAO.DeleteSchoolClass(schoolClass);
        }

        public SchoolClassVO FindSchoolClass(long schoolClassId)
        {
            return _schoolClassDAO.FindSchoolClass(schoolClassId);
        }

        public void InserSchoolClass(SchoolClassVO newSchoolClass)
        {
            _schoolClassDAO.InserSchoolClass(newSchoolClass);
        }

        public void UpdateSchoolClass(SchoolClassVO schoolClass)
        {
            _schoolClassDAO.UpdateSchoolClass(schoolClass);
        }
    }
}
