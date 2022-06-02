using TraLoginApi.Common.Jwt;
using TraLoginApi.Data.Dtos;

namespace TraLoginApi.Common
{
    public class LoginResult
    {
        public bool Success { get; set; } 
        public string Message { get; set; } 
        public AccessToken AccessToken { get; set; }
        public UserInfoDto User  { get; set; }


        public LoginResult(bool success)
        {
            this.Success = success;
        }  
        public LoginResult(bool success,string message)
        {
            this.Success = success;
            this.Message = message;
        }
        public LoginResult(bool success,string message,AccessToken accessToken,UserInfoDto user)
        {
            this.Success = success;
            this.Message = message;
            this.AccessToken = accessToken;
            this.User = user;

        }
    }
}
