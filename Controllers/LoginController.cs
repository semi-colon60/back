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

		[HttpGet("{email}/getByEmail")]
		public async Task<IActionResult> GetByEmailAsync(string email, string password)
		{
			var result = await _loginService.GetByEmailAsync(email, password);
			if (result == null)
				return NotFound("User Not Found!");
			return Ok(result);
		}

		[HttpGet("{username}/getByUsername")]
		public async Task<IActionResult> GetByUsernameAsync(string username, string password)
		{
			var result = await _loginService.GetByUsernameAsync(username, password);
			if (result == null)
				return NotFound("User Not Found!");
			return Ok(result);
		}

	}
}