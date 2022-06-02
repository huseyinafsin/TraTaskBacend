using TraLoginApi.Common;
using TraLoginApi.Common.Services;
using TraLoginApi.Common.Jwt;
using TraLoginApi.Data.Dtos;
using System.Threading.Tasks;
using AutoMapper;

namespace TraLoginApi.Services
{
    public class AuthService : IAuthService
    {
        private readonly ITokenHelper _tokenHelper;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;



        public AuthService(ITokenHelper tokenHelper, IUserService userService, IMapper mapper)
        {
            _tokenHelper = tokenHelper;
            _userService = userService;
            _mapper = mapper;
        }
        public async Task<LoginResult> Login(LoginDto loginDto)
        {
            var userToCheck = await _userService.GetByUsernameAsync(loginDto.Username);
            if (userToCheck ==null)
            {
                return new LoginResult(false, "User Not Found");
            }
            if (userToCheck.Password!=loginDto.Password)
            {
                return new LoginResult(false, "Username or password is wrong!");
            }

           var accessToken = _tokenHelper.CreateToken(userToCheck);

            var userDto = _mapper.Map<UserInfoDto>(userToCheck);

            return new LoginResult(true, "Login Successful!",accessToken,userDto);

        }
    }
}
