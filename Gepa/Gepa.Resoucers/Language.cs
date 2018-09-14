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

        /// <summary>
        /// Registre-se
        /// </summary>
        public static string Register
        {
            get
            {
                return GetString("Register");
            }
        }

        /// <summary>
        /// Login
        /// </summary>
        public static string Login
        {
            get
            {
                return GetString("Login");
            }
        }

        /// <summary>
        /// Conecte-se com Facebook
        /// </summary>
        public static string ConnectFacebook
        {
            get
            {
                return GetString("ConnectFacebook");
            }
        }

        /// <summary>
        /// Conecte-se com Google
        /// </summary>
        public static string ConnectGoogle
        {
            get
            {
                return GetString("ConnectGoogle");
            }
        }

        /// <summary>
        /// Informe seu endereço de e-mail ou nome de usuário:
        /// </summary>
        public static string EnterYourEmailAddressOrUsername
        {
            get
            {
                return GetString("EnterYourEmailAddressOrUsername");
            }
        }

        /// <summary>
        /// Informe sua senha:
        /// </summary>
        public static string EnterYourPassword
        {
            get
            {
                return GetString("EnterYourPassword");
            }
        }

        /// <summary>
        /// Esqueceu sua senha?
        /// </summary>
        public static string ForgotYourPassword
        {
            get
            {
                return GetString("ForgotYourPassword");
            }
        }

        /// <summary>
        /// Não tem cadastro ainda? Registre-se
        /// </summary>
        public static string DontHaveAccountYetDoRegister
        {
            get
            {
                return GetString("DontHaveAccountYetDoRegister");
            }
        }

        /// <summary>
        /// Já é cadastrado? Faça o login
        /// </summary>
        public static string AlreadyRegisteredSignIn
        {
            get
            {
                return GetString("AlreadyRegisteredSignIn");
            }
        }
    }
}
