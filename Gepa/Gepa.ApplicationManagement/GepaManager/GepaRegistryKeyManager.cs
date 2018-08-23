using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepaManagement
{
    public static class GepaRegistryKeyManager
    {
        private static string _SERVER_KEY_PATH = @"SOFTWARE\GEPA\Server";

        public static string GetStringValueOfKey(string name)
        {
            string result = string.Empty;
            using (RegistryKey localMachineRegistry = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32))
            {
                using (RegistryKey key = localMachineRegistry.OpenSubKey(_SERVER_KEY_PATH))
                {
                    object value = key.GetValue(name);
                    if (value != null && value is string)
                    {
                        result = (string)value;
                    }
                }
            }
            return result;
        }
    }
}
