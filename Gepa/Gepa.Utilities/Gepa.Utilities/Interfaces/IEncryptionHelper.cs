using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.Utilities.Interfaces
{
    public interface IEncryptionHelper
    {
        string EncryptString(string text);
        string DescryptString(string encryptedText);
    }
}
