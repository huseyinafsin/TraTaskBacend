using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraLoginApi.Common.Services;
using TraLoginApi.Data.Dtos;

namespace TraLoginApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private  readonly IAuthService _authService;


        public AuthController(IAuthService authService)
        {
            _authService = authService;
          
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
           var result = await _authService.Login(loginDto);
           if (result.Success)
           {
               return Ok(result);
           }
           return BadRequest(result);
        }
    }
}
