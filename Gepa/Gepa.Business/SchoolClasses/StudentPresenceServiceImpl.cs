using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gepa.DAO.SchoolClasses;
using Gepa.Entities.Framework.Entities.SchoolClasses;

namespace Gepa.Business.SchoolClasses
{
    public class StudentPresenceServiceImpl : IStudentPresenceService
    {
        private IStudentPresenceDAO _studentPresenceDAO;

        public StudentPresenceServiceImpl(IStudentPresenceDAO studentPresenceDAO)
        {
            _studentPresenceDAO = studentPresenceDAO;
        }

        public void DeleteStudentPresense(StudentPresence studentPresence)
        {
            _studentPresenceDAO.DeleteStudentPresense(studentPresence);
        }

        public StudentPresence FindStudentPresnece(long studentPresenceID)
        {
            return _studentPresenceDAO.FindStudentPresnece(studentPresenceID);
        }

        public async Task<StudentPresence> FindStudentPresneceAsync(long studentPresenceID)
        {
            return await _studentPresenceDAO.FindStudentPresneceAsync(studentPresenceID);
        }

        public void InsertStudentPresence(StudentPresence newStudentPresnece)
        {
            _studentPresenceDAO.InsertStudentPresence(newStudentPresnece);
        }

        public void UpdateStudentPresence(StudentPresence studentPresnece)
        {
            _studentPresenceDAO.UpdateStudentPresence(studentPresnece);
        }
    }
}
