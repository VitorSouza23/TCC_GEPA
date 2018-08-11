using Gepa.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.SchoolClasses
{
    public interface IStudentPresenceDAO
    {
        void InsertStudentPresence(StudentPresenceVO newStudentPresnece);
        void UpdateStudentPresence(StudentPresenceVO studentPresnece);
        void DeleteStudentPresense(StudentPresenceVO studentPresence);
        StudentPresenceVO FindStudentPresnece(long studentPresenceID);
    }
}
