using Gepa.Resources.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gepa.Resources
{
    public class Language
    {

        protected static string GetString(string stringName)
        {
            switch (Thread.CurrentThread.CurrentCulture.Name)
            {
                default:
                    return pt_BR.ResourceManager.GetString(stringName);
            }
        }

        /// <summary>
        /// Gepa
        /// </summary>
        public static string Gepa
        {
            get
            {
                return GetString("Gepa");
            }
        }
    }
}
