using Gepa.Utilities.Algorithms;
using Gepa.Utilities.Interfaces;
using System.Data.Common;

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
        private static string _GOOGLE_CLIENT = string.Empty;
        private static string _PROVAIDER_KEY_VALUE_NAME = "Provider";
        private static string _CONNECTION_STRING_KEY_VALUE_NAME = "Connection";
        private static string _IDENTITY_CONNECTION_STRING_KEY_VALUE_NAME = "IdentityConnection";
        private static string _GOOLGE_CLIENT_KEY_NAME = "GoogleClient";
        private static object _LOCK = new object();
        private static DbConnection _DB_CONNECTION;
        private static DbConnection _IDENTITY_DB_CONNECTION;

        private static void ReadRegistryKeys()
        {
            string conectionStringEncrypted = GepaRegistryKeyManager.GetStringValueOfKey(_CONNECTION_STRING_KEY_VALUE_NAME);
            string providerNameEncrypted = GepaRegistryKeyManager.GetStringValueOfKey(_PROVAIDER_KEY_VALUE_NAME);
            string identityStringEncrypted = GepaRegistryKeyManager.GetStringValueOfKey(_IDENTITY_CONNECTION_STRING_KEY_VALUE_NAME);
            string googleClientEncrypted = GepaRegistryKeyManager.GetStringValueOfKey(_GOOLGE_CLIENT_KEY_NAME);

            IEncryptionHelper encryptor = new MD5CryptoHelper();
            _CONNECTION_STRING = encryptor.DescryptString(conectionStringEncrypted);
            _PROVIDER_NAME = encryptor.DescryptString(providerNameEncrypted);
            _IDENTITY_CONNECTION_STRING = encryptor.DescryptString(identityStringEncrypted);
            _GOOGLE_CLIENT = encryptor.DescryptString(googleClientEncrypted);

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

        public string GetGoogleClientSecret()
        {
            if (string.IsNullOrWhiteSpace(_GOOGLE_CLIENT))
                ReadRegistryKeys();
            return _GOOGLE_CLIENT;
        }

        public DbConnection GetDataBaseDefaultConnection()
        {
            if (_DB_CONNECTION == null)
                CreateDBConnection();
            return _DB_CONNECTION;
        }

    }
}
