using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.SchoolClasses;
using Gepa.Entities.SchoolClasses;

namespace Gepa.Business.SchoolClasses
{
    public class StudentPresenceServiceImpl : IStudentPresenceService
    {
        private IStudentPresenceDAO _studentPresenceDAO;

        public StudentPresenceServiceImpl(IStudentPresenceDAO studentPresenceDAO)
        {
            _studentPresenceDAO = studentPresenceDAO;
        }

        public void DeleteStudentPresense(StudentPresenceVO studentPresence)
        {
            _studentPresenceDAO.DeleteStudentPresense(studentPresence);
        }

        public StudentPresenceVO FindStudentPresnece(long studentPresenceID)
        {
            return _studentPresenceDAO.FindStudentPresnece(studentPresenceID);
        }

        public void InsertStudentPresence(StudentPresenceVO newStudentPresnece)
        {
            _studentPresenceDAO.InsertStudentPresence(newStudentPresnece);
        }

        public void UpdateStudentPresence(StudentPresenceVO studentPresnece)
        {
            _studentPresenceDAO.UpdateStudentPresence(studentPresnece);
        }
    }
}
