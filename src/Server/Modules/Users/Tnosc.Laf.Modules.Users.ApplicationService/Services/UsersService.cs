using Tnosc.Laf.Modules.Users.ApplicationService.Contracts;
using Tnosc.Laf.Modules.Users.Shared.Dtos;

namespace Tnosc.Laf.Modules.Users.ApplicationService.Services
{
    internal sealed class UsersService : IUsersService
    {
        public Task ConfirmEmail(string userId, string code)
        {
            throw new NotImplementedException();
        }

        public void ExternalLogin()
        {
            throw new NotImplementedException();
        }

        public void ExternalLoginCallback()
        {
            throw new NotImplementedException();
        }

        public void ExternalLoginConfirmation()
        {
            throw new NotImplementedException();
        }

        public void ForgotPassword()
        {
            throw new NotImplementedException();
        }

        public void ForgotPasswordConfirmation()
        {
            throw new NotImplementedException();
        }

        public UserDto GetUser(string Email)
        {
            throw new NotImplementedException();
        }

        public UserDto GetUserById(string ID)
        {
            throw new NotImplementedException();
        }

        public Task Login(string email, string password, bool rememberMe)
        {
            throw new NotImplementedException();
        }

        public void Logoff()
        {
            throw new NotImplementedException();
        }

        public Task Register(UserDto user, string password)
        {
            throw new NotImplementedException();
        }

        public void ResetPassword()
        {
            throw new NotImplementedException();
        }

        public void ResetPasswordConfirmation()
        {
            throw new NotImplementedException();
        }

        public void SendCode()
        {
            throw new NotImplementedException();
        }

        public Task VerifyCode(string provider, string code, bool rememberMe, bool rememberBrowser)
        {
            throw new NotImplementedException();
        }
    }
}
