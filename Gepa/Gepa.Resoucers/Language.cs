using Gepa.Resources.Languages;
using System.Threading;

namespace Gepa.Resources
{
    public static class Language
    {

        public static string GetString(string stringName)
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

        /// <summary>
        /// Título
        /// </summary>
        public static string Title
        {
            get
            {
                return GetString("Title");
            }
        }

        /// <summary>
        /// Descrição
        /// </summary>
        public static string Description
        {
            get
            {
                return GetString("Description");
            }
        }

        /// <summary>
        /// Metodologia
        /// </summary>
        public static string Methodology
        {
            get
            {
                return GetString("Methodology");
            }
        }

        /// <summary>
        /// Data
        /// </summary>
        public static string Date
        {
            get
            {
                return GetString("Date");
            }
        }

        /// <summary>
        /// Observações
        /// </summary>
        public static string Observations
        {
            get
            {
                return GetString("Observations");
            }
        }

        /// <summary>
        /// Insira a {0}
        /// </summary>
        public static string EnterFieldValueFormatted
        {
            get
            {
                return GetString("EnterFieldValueFormatted");
            }
        }

        /// <summary>
        /// Insira o {0}
        /// </summary>
        public static string EnterFieldValueFormatted2
        {
            get
            {
                return GetString("EnterFieldValueFormatted2");
            }
        }

        /// <summary>
        /// Insira as {0}
        /// </summary>
        public static string EnterFieldValueFormatted3
        {
            get
            {
                return GetString("EnterFieldValueFormatted3");
            }
        }

        /// <summary>
        /// Senha
        /// </summary>
        public static string Password
        {
            get
            {
                return GetString("Password");
            }
        }

        /// <summary>
        /// Email ou Nome de Usuário
        /// </summary>
        public static string EmailOrUserName
        {
            get
            {
                return GetString("EmailOrUserName");
            }
        }

        /// <summary>
        /// O e-mail ou nome de usuário e senha não correposndem, verifique se os campos foram preechisdos corretamente.
        /// </summary>
        public static string InvalidLoginError
        {
            get
            {
                return GetString("InvalidLoginError");
            }
        }

        /// <summary>
        /// Talvez o e-mail ou nome de usuário não exista.
        /// </summary>
        public static string MaybeTheUserNameDoesNotExistError
        {
            get
            {
                return GetString("MaybeTheUserNameDoesNotExistError");
            }
        }

        /// <summary>
        /// Talvez a senha esteja incorreta.
        /// </summary>
        public static string MaybeThePasswordBeIncorrectError
        {
            get
            {
                return GetString("MaybeThePasswordBeIncorrectError");
            }
        }

        /// <summary>
        /// E-mail
        /// </summary>
        public static string Email
        {
            get
            {
                return GetString("Email");
            }
        }

        /// <summary>
        /// Falha de logon
        /// </summary>
        public static string LogonFailure
        {
            get
            {
                return GetString("LogonFailure");
            }
        }

        /// <summary>
        /// Falha ao fazer logon no serviço.
        /// </summary>
        public static string LogonFailureMessage
        {
            get
            {
                return GetString("LogonFailureMessage");
            }
        }

        /// <summary>
        /// Associe sua conta
        /// </summary>
        public static string AssociateYourAccount
        {
            get
            {
                return GetString("AssociateYourAccount");
            }
        }

        /// <summary>
        /// Formas de associação
        /// </summary>
        public static string AssociationForms
        {
            get
            {
                return GetString("AssociationForms");
            }
        }

        /// <summary>
        /// Você se autenticou com êxito com <strong>{0}</strong>. Insira um nome de usuário para este site abaixo e clique no botão Registrar para concluir o login.
        /// </summary>
        /// <param name="loginProvider"></param>
        /// <returns></returns>
        public static string SuccessfulAuthenticationMessage(string loginProvider)
        {
            return string.Format(GetString("SuccessfulAuthenticationMessage"), loginProvider);
        }

        /// <summary>
        /// Confirmar senha
        /// </summary>
        public static string ConfirmPassword
        {
            get
            {
                return GetString("ConfirmPassword");
            }
        }

        /// <summary>
        /// A {0} deve ter no mínimo {2} caracteres.
        /// </summary>
        public static string PasswordWithInvalidSizeErrorMessage
        {
            get
            {
                return GetString("PasswordWithInvalidSizeErrorMessage");
            }
        }

        /// <summary>
        /// A senha e a senha de confirmação não correspondem.
        /// </summary>
        public static string VerificationPasswordDoesNotMatchErrorMessage
        {
            get
            {
                return GetString("VerificationPasswordDoesNotMatchErrorMessage");
            }
        }

        /// <summary>
        /// Bem-vindo, {0}
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static string WelComeUserMessage(string userName)
        {
            return string.Format(GetString("WelComeUserMessage"), userName);
        }

        /// <summary>
        /// Cadastrar
        /// </summary>
        public static string Register2
        {
            get
            {
                return GetString("Register2");
            }
        }

        /// <summary>
        /// Plano de aula
        /// </summary>
        public static string ClassPlan
        {
            get
            {
                return GetString("ClassPlan");
            }
        }

        /// <summary>
        /// Configurações do professor
        /// </summary>
        public static string TeacherSettings
        {
            get
            {
                return GetString("TeacherSettings");
            }
        }

        /// <summary>
        /// Sair
        /// </summary>
        public static string GetOut
        {
            get
            {
                return GetString("GetOut");
            }
        }

        /// <summary>
        /// Cadastro do Plano de Aula
        /// </summary>
        public static string CreateClassPlan
        {
            get
            {
                return GetString("CreateClassPlan");
            }
        }

        /// <summary>
        /// Cadastrar plano de aula
        /// </summary>
        public static string RegisterClassPlan
        {
            get
            {
                return GetString("RegisterClassPlan");
            }
        }

        /// <summary>
        /// Divisão do conteúdo
        /// </summary>
        public static string DivisionOfContent
        {
            get
            {
                return GetString("DivisionOfContent");
            }
        }

        /// <summary>
        /// Adicionar
        /// </summary>
        public static string Add
        {
            get
            {
                return GetString("Add");
            }
        }

        /// <summary>
        /// Editar
        /// </summary>
        public static string Edit
        {
            get
            {
                return GetString("Edit");
            }
        }


        // <summary>
        /// Excluir
        /// </summary>
        public static string Exclude
        {
            get
            {
                return GetString("Exclude");
            }
        }

        // <summary>
        /// Salvar
        /// </summary>
        public static string Save
        {
            get
            {
                return GetString("Save");
            }
        }

        // <summary>
        /// Cancelar
        /// </summary>
        public static string Cancel
        {
            get
            {
                return GetString("Cancel");
            }
        }

        // <summary>
        /// Adicionar Conteúdo
        /// </summary>
        public static string AddContent
        {
            get
            {
                return GetString("AddContent");
            }
        }

        // <summary>
        /// Conteúdo
        /// </summary>
        public static string Content
        {
            get
            {
                return GetString("Content");
            }
        }

        /// <summary>
        /// Linguagem
        /// </summary>
        public static string CultureLanguage
        {
            get
            {
                return GetString("CultureLanguage");
            }
        }

        /// <summary>
        /// Nome
        /// </summary>
        public static string Name
        {
            get
            {
                return GetString("Name");
            }
        }

        /// <summary>
        /// Nome de usuário
        /// </summary>
        public static string UserName
        {
            get
            {
                return GetString("UserName");
            }
        }

        /// <summary>
        /// Português (Brsil)
        /// </summary>
        public static string PtBR
        {
            get
            {
                return GetString("PtBR");
            }
        }

        /// <summary>
        /// OK
        /// </summary>
        public static string Ok
        {
            get
            {
                return GetString("Ok");
            }
        }


        /// <summary>
        /// Selecione um conteúdo para continuar a operação desejada.
        /// </summary>
        public static string SelectContentToContinueOperationMessage
        {
            get
            {
                return GetString("SelectContentToContinueOperationMessage");
            }
        }

        /// <summary>
        /// Não há conteúdo selecionado!
        /// </summary>
        public static string NoLessonContentSelected
        {
            get
            {
                return GetString("NoLessonContentSelected");
            }
        }

        /// <summary>
        /// Objetivo concluído
        /// </summary>
        public static string IsCompletedGoal
        {
            get
            {
                return GetString("IsCompletedGoal");
            }
        }

        /// <summary>
        /// Objetivo
        /// </summary>
        public static string Goal
        {
            get
            {
                return GetString("Goal");
            }
        }

        /// <summary>
        /// Objetivos
        /// </summary>
        public static string Goals
        {
            get
            {
                return GetString("Goals");
            }
        }

        /// <summary>
        /// Adicionar Objetivo
        /// </summary>
        public static string AddClassGoal
        {
            get
            {
                return GetString("AddClassGoal");
            }
        }

        /// <summary>
        /// Nenhum item selecionado!
        /// </summary>
        public static string NoItemSelected
        {
            get
            {
                return GetString("NoItemSelected");
            }
        }

        /// <summary>
        /// Avaliações
        /// </summary>
        public static string Evaluations
        {
            get
            {
                return GetString("Evaluations");
            }
        }

        /// <summary>
        /// Tarefa concluida
        /// </summary>
        public static string IsCompletedTask
        {
            get
            {
                return GetString("IsCompletedTask");
            }
        }

        /// <summary>
        /// Atividades
        /// </summary>
        public static string Chores
        {
            get
            {
                return GetString("Chores");
            }
        }

        /// <summary>
        /// Não há planos de aula cadastrados ainda
        /// </summary>
        public static string NoClassPlanSaved
        {
            get
            {
                return GetString("NoClassPlanSaved");
            }
        }

        /// <summary>
        /// Disciplina
        /// </summary>
        public static string Subject
        {
            get
            {
                return GetString("Subject");
            }
        }

        /// <summary>
        /// Para inserir um conteúdo, clique no botão 'Adicionar'.
        /// </summary>
        public static string LessonContentPlaceholder
        {
            get
            {
                return GetString("LessonContentPlaceholder");
            }
        }


        /// <summary>
        /// Para inserir um objetivo, clique no botão 'Adicionar'.
        /// </summary>
        public static string ClassGoalPlaceholder
        {
            get
            {
                return GetString("ClassGoalPlaceholder");
            }
        }

        /// <summary>
        /// Para inserir uma atividade, clique no botão 'Adicionar'.
        /// </summary>
        public static string ChorePlaceholder
        {
            get
            {
                return GetString("ChorePlaceholder");
            }
        }

        /// <summary>
        /// Para inserir uma avaliação, clique no botão 'Adicionar'.
        /// </summary>
        public static string EvaluationPlaceholder
        {
            get
            {
                return GetString("EvaluationPlaceholder");
            }
        }

    }
}
