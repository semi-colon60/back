using dotnet.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{

		private readonly ILoginService _loginService;

		public LoginController(ILoginService loginService)
		{
			_loginService = loginService;
		}

		[HttpGet("LoginEmail/{email}")]
		public async Task<IActionResult> LogInByEmailAsync(string email, string password)
		{
			var result = await _loginService.GetCommercialIdByEmailAsync(email, password);
			if (result == null)
				return NotFound("User Not Found!");
			return Ok(result);
		}

		[HttpGet("LoginUsername/{username}")]
		public async Task<IActionResult> LogInByUsernameAsync(string username, string password)
		{
			var result = await _loginService.GetCommercialIdByUsernameAsync(username, password);
			if (result == null)
				return NotFound("User Not Found!");
			return Ok(result);
		}

	}
}