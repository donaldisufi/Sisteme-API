using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using school.Interfaces;
using school.Models;
using school.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school.Controllers
{
    [Route("api/login")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly IUser<User> _userRep;
        private ILogger<AccountController> _logger;
        public AccountController(IUser<User> userRep, ILogger<AccountController> logger)
        {
            _logger = logger;
            _userRep = userRep;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
			if (ModelState.IsValid)
			{
				var user = await _userRep.Login(loginModel);
				if (user != null)
				{
					_logger.Log(LogLevel.Information, "Login request", loginModel.Username);
					return Ok(new HttpResponseToken(user.Token, user.Role.RoleName));
				}
				_logger.Log(LogLevel.Warning, "Incorrect email or password");
				return BadRequest(new DataError("Incorrect email or password"));
			}
			_logger.Log(LogLevel.Warning, "Not valid");
			return BadRequest(new DataError("Not valid"));

        }
    }
}
