using Gepa.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Utilities.Algorithms
{
    public class MD5CryptoHelper : IEncryptionHelper
    {
        private static string _HASH = "G3p@Pa_s";
        public string DescryptString(string encryptedText)
        {
            string descryptedText = null;
            if (string.IsNullOrEmpty(encryptedText) == false)
            {
                byte[] data = Convert.FromBase64String(encryptedText);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_HASH));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                    {
                        Key = keys,
                        Mode = CipherMode.ECB,
                        Padding = PaddingMode.PKCS7
                    })
                    {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        descryptedText = UTF8Encoding.UTF8.GetString(results);
                    }
                }
            }

            return descryptedText;
        }

        public string EncryptString(string text)
        {
            string encryptedText = null;
            byte[] data = UTF8Encoding.UTF8.GetBytes(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_HASH));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                {
                    Key = keys,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    encryptedText = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return encryptedText;
        }
    }
}
