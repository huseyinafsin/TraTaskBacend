using TraLoginApi.Data.Models;

namespace TraLoginApi.Common.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user);
    }
}
