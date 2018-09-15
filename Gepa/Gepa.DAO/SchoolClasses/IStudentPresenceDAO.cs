using Gepa.Entities.Framework.Entities.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO.SchoolClasses
{
    public interface IStudentPresenceDAO
    {
        void InsertStudentPresence(StudentPresence newStudentPresnece);
        void UpdateStudentPresence(StudentPresence studentPresnece);
        void DeleteStudentPresense(StudentPresence studentPresence);
        StudentPresence FindStudentPresnece(long studentPresenceID);
        Task<StudentPresence> FindStudentPresneceAsync(long studentPresenceID);
    }
}
