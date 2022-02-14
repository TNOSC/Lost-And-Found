using Tnosc.Laf.Modules.Users.Shared.Dtos;

namespace Tnosc.Laf.Modules.Users.ApplicationService.Contracts
{
    public interface IUsersService
    {
        Task Register(UserDto user, string password);
        Task Login(string email, string password, bool rememberMe);
        Task VerifyCode(string provider, string code, bool rememberMe, bool rememberBrowser);
        Task ConfirmEmail(string userId, string code);
        void ForgotPassword();
        void ForgotPasswordConfirmation();
        void ResetPassword();
        void ResetPasswordConfirmation();
        void ExternalLogin();
        void SendCode();
        void ExternalLoginCallback();
        void ExternalLoginConfirmation();
        void Logoff();
        UserDto GetUser(string Email);
        UserDto GetUserById(string ID);
    }
}