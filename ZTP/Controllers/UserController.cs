using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZTP.Common.DTO;
using ZTP.Interfaces.Facades;

namespace ZTP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserFcd _userFcd;

        public UserController(ILogger<UserController> logger,
            IUserFcd userFcd)
        {
            _logger = logger;
            _userFcd = userFcd;
        }
        [HttpPost("RegisterUser")]
        public async Task<ActionResult> Register(AppUserDTO user, string password)
        {
            var result = await _userFcd.Register(user, password);
            return (result.Success) ? Ok(result.Message) : NotFound(result.Message);
        }

        [HttpPost("LoginUser")]
        public async Task<ActionResult> Login(string login, string password)
        {
            var result = await _userFcd.Login(login, password);
            return (result.Success) ? Ok(result.Message) : NotFound(result.Message);
        }

        [HttpGet("GetUserProfileInfo")]
        public async Task<ActionResult> GetUserProfileInfo(string id)
        {
            var data = await _userFcd.getUserInfo(id);
            return (data != null) ? Ok(data) : NotFound("Nie udalo zdobyć danych");
        }
    }
}
