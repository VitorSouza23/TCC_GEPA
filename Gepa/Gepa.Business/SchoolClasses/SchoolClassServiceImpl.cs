using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.SchoolClasses;
using Gepa.Entities.Framework.Entities.SchoolClasses;

namespace Gepa.Business.SchoolClasses
{
    public class SchoolClassServiceImpl : ISchoolClassService
    {
        private ISchoolClassDAO _schoolClassDAO;

        public SchoolClassServiceImpl(ISchoolClassDAO schoolClassDAO)
        {
            _schoolClassDAO = schoolClassDAO;
        }

        public void DeleteSchoolClass(SchoolClass schoolClass)
        {
            _schoolClassDAO.DeleteSchoolClass(schoolClass);
        }

        public SchoolClass FindSchoolClass(long schoolClassId)
        {
            return _schoolClassDAO.FindSchoolClass(schoolClassId);
        }

        public void InserSchoolClass(SchoolClass newSchoolClass)
        {
            _schoolClassDAO.InserSchoolClass(newSchoolClass);
        }

        public void UpdateSchoolClass(SchoolClass schoolClass)
        {
            _schoolClassDAO.UpdateSchoolClass(schoolClass);
        }
    }
}
