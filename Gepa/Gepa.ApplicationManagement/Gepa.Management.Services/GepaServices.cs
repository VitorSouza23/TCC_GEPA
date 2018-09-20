using Gepa.Business;
using Gepa.Business.Calendar;
using Gepa.Business.ClassPlans;
using Gepa.Business.SchoolClasses;
using Gepa.Business.Users;
using Gepa.DAO.Calendar;
using Gepa.DAO.ClassPlans;
using Gepa.DAO.SchoolClasses;
using Gepa.DAO.Users;
using Gepa.Management.Services.ServicesTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Management.Services
{
    public class GepaServices
    {
        private static GepaServices _instance;

        private GepaServices()
        {
        }
        private static object _LOCK = new object();

        public static GepaServices Instance
        {
            get
            {
                lock (_LOCK)
                {
                    if (_instance == null)
                        _instance = new GepaServices();
                    return _instance;
                }
            }
        }

        public IGepaService GetService(GepaServicesTypes serviceType)
        {
            switch (serviceType)
            {
                case GepaServicesTypes.AbstractShoolEventService:
                    return new AbstractSchoolEventServiceImpl(new AbstractSchoolEventDAOImpl());
                case GepaServicesTypes.ChoresService:
                    return new ChoresServiceImpl(new ChoresDAOImpl());
                case GepaServicesTypes.ClassDiaryService:
                    return new ClassDiaryServiceImpl(new ClassDiaryDAOImpl());
                case GepaServicesTypes.ClassFrequencyService:
                    return new ClassFrequencyServiceImpl(new ClassFrequencyDAOImpl());
                case GepaServicesTypes.ClassGoalsService:
                    return new ClassGoalsServiceImpl(new ClassGoalsDAOImpl());
                case GepaServicesTypes.ClassPlanService:
                    return new ClassPlanServiceImpl(new ClassPlanDAOImpl());
                case GepaServicesTypes.EvaluationService:
                    return new EvaluationServiceImpl(new EvaluationDAOImpl());
                case GepaServicesTypes.LessonsContentService:
                    return new LessonsContentServiceImpl(new LessonsContentDAOImpl());
                case GepaServicesTypes.SchoolCalendarService:
                    return new SchoolCalendarServiceImpl(new SchoolCalendarDAOImpl());
                case GepaServicesTypes.SchoolClassService:
                    return new SchoolClassServiceImpl(new SchoolClassDAOImpl());
                case GepaServicesTypes.StudentNoteService:
                    return new StudentNoteServiceImpl(new StudentNoteDAOImpl());
                case GepaServicesTypes.StudentPresenceService:
                    return new StudentPresenceServiceImpl(new StudentPresenceDAOImpl());
                case GepaServicesTypes.StudentService:
                    return new StudentServiceImpl(new StudentDAOImpl());
                case GepaServicesTypes.TeacherService:
                    return new TeacherServiceImpl(new TeacherDAOImpl());
                case GepaServicesTypes.SchoolService:
                    return new SchoolServiceImpl(new SchoolDAOImpl());
                default:
                    return null;
            }
        }
    }
}
