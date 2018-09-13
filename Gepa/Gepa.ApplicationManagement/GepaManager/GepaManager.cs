using Gepa.Business;
using Gepa.Business.Calendar;
using Gepa.Business.ClassPlans;
using Gepa.Business.SchoolClasses;
using Gepa.Business.Users;
using Gepa.DAO.Calendar;
using Gepa.DAO.ClassPlans;
using Gepa.DAO.SchoolClasses;
using Gepa.DAO.Users;
using Gepa.Utilities.Algorithms;
using Gepa.Utilities.Interfaces;
using GepaManagement.ServicesTypes;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepaManagement
{
    public class GepaManager
    {
        private static GepaManager _instance;

        private GepaManager()
        {
            ReadRegistryKeys();
        }

        public static GepaManager Instance
        {
            get
            {
                lock (_LOCK)
                {
                    if (_instance == null)
                        _instance = new GepaManager();
                    return _instance;
                }
            }
        }

        private static string _CONNECTION_STRING = string.Empty;
        private static string _PROVIDER_NAME = string.Empty;
        private static string _IDENTITY_CONNECTION_STRING = string.Empty;
        private static string _PROVAIDER_KEY_VALUE_NAME = "Provider";
        private static string _CONNECTION_STRING_KEY_VALUE_NAME = "Connection";
        private static string _IDENTITY_CONNECTION_STRING_KEY_VALUE_NAME = "IdentityConnection";
        private static object _LOCK = new Object();
        private static DbConnection _DB_CONNECTION;
        private static DbConnection _IDENTITY_DB_CONNECTION;

        private static void ReadRegistryKeys()
        {
            string conectionStringEncrypted = GepaRegistryKeyManager.GetStringValueOfKey(_CONNECTION_STRING_KEY_VALUE_NAME);
            string providerNameEncrypted = GepaRegistryKeyManager.GetStringValueOfKey(_PROVAIDER_KEY_VALUE_NAME);
            string identityStringEncrypted = GepaRegistryKeyManager.GetStringValueOfKey(_IDENTITY_CONNECTION_STRING_KEY_VALUE_NAME);

            IEncryptionHelper encryptor = new MD5CryptoHelper();
            _CONNECTION_STRING = encryptor.DescryptString(conectionStringEncrypted);
            _PROVIDER_NAME = encryptor.DescryptString(providerNameEncrypted);
            _IDENTITY_CONNECTION_STRING = encryptor.DescryptString(identityStringEncrypted);
        }

        private void CreateDBConnection()
        {
            if (string.IsNullOrWhiteSpace(_PROVIDER_NAME) || string.IsNullOrWhiteSpace(_CONNECTION_STRING))
                ReadRegistryKeys();

            _DB_CONNECTION = DbProviderFactories.GetFactory(_PROVIDER_NAME).CreateConnection();
            _DB_CONNECTION.ConnectionString = _CONNECTION_STRING;
        }

        private void CreateIdentityDBConnection()
        {
            if (string.IsNullOrWhiteSpace(_PROVIDER_NAME) || string.IsNullOrWhiteSpace(_IDENTITY_CONNECTION_STRING))
                ReadRegistryKeys();

            _IDENTITY_DB_CONNECTION = DbProviderFactories.GetFactory(_PROVIDER_NAME).CreateConnection();
            _IDENTITY_DB_CONNECTION.ConnectionString = _IDENTITY_CONNECTION_STRING;
        }

        public DbConnection GetIdentityDbConnection()
        {
            if (_IDENTITY_DB_CONNECTION == null)
                CreateIdentityDBConnection();
            return _IDENTITY_DB_CONNECTION;
        }


        public IGepaService GetService(GepaServicesTypes serviceType)
        {
            if (_DB_CONNECTION == null)
                CreateDBConnection();

            switch (serviceType)
            {
                case GepaServicesTypes.AbstractShoolEventService:
                    return new AbstractSchoolEventServiceImpl(new AbstractSchoolEventDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.ChoresService:
                    return new ChoresServiceImpl(new ChoresDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.ClassDiaryService:
                    return new ClassDiaryServiceImpl(new ClassDiaryDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.ClassFrequencyService:
                    return new ClassFrequencyServiceImpl(new ClassFrequencyDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.ClassGoalsService:
                    return new ClassGoalsServiceImpl(new ClassGoalsDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.ClassPlanService:
                    return new ClassPlanServiceImpl(new ClassPlanDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.EvaluationService:
                    return new EvaluationServiceImpl(new EvaluationDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.LessonsContentService:
                    return new LessonsContentServiceImpl(new LessonsContentDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.SchoolCalendarService:
                    return new SchoolCalendarServiceImpl(new SchoolCalendarDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.SchoolClassService:
                    return new SchoolClassServiceImpl(new SchoolClassDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.StudentNoteService:
                    return new StudentNoteServiceImpl(new StudentNoteDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.StudentPresenceService:
                    return new StudentPresenceServiceImpl(new StudentPresenceDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.StudentService:
                    return new StudentServiceImpl(new StudentDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.TeacherService:
                    return new TeacherServiceImpl(new TeacherDAOImpl(_DB_CONNECTION));
                case GepaServicesTypes.SchoolService:
                    return new SchoolServiceImpl(new SchoolDAOImpl(_DB_CONNECTION));
                default:
                    return null;
            }
        }

    }
}
