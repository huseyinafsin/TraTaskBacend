using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraLoginApi.Common.Services;
using TraLoginApi.Data.Dtos;
using TraLoginApi.Data.Models;

namespace TraLoginApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IUserService  _userService;

        public ProfileController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {

            var result = "Logged in Successful";
            return Ok(result);
        }
    }
}
