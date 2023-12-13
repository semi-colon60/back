using dotnet.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProfileController : ControllerBase
	{
		private readonly IProfileService _IProfileService;

		public ProfileController(IProfileService profileService)
		{
			// Console.WriteLine("xd");
			// Console.WriteLine("\n\n\nxd\n\n\n");
			// Console.WriteLine( + "\n");

			_IProfileService = profileService;

		}

		[HttpGet("{userid}")]
		public async Task<IActionResult> GetProfileAsync(long userid)
		{
			var result = await _IProfileService.GetCommercialIdById(userid);
			if (result == null)
				return NotFound("User Not Found!");
			return Ok(result);
		}

		[HttpPost("AddAddress")]
		public async Task<IActionResult> AddAddressAsync(Address address)
		{
			throw new NotImplementedException();
		}

		[HttpPut("UpdateAddressInfo")]
		public async Task<IActionResult> UpdateAdressInfosAsync(Address address)
		{
			throw new NotImplementedException();
		}

		[HttpPut("UpdatePhone/{userid}")]
		public async Task<IActionResult> UpdatePhoneAsync(long userid, [FromBody] string phone)
		{
			Console.WriteLine(phone);
			var result = await _IProfileService.UpdatePhone(userid, phone);
			if (result == null)
				return NotFound("User Not Found!");
			return Ok(result.Phone);
		}

		[HttpPut("UpdateEmail/{userid}")]
		public async Task<IActionResult> UpdateEmailAsync(long userid, [FromBody] string email)
		{
			var result = await _IProfileService.UpdateEmail(userid, email);
			if (result == null)
				return NotFound("User Not Found!");
			return Ok(result.Email);
		}

		[HttpPut("UpdateUsername/{userid}")]
		public async Task<IActionResult> UpdateUsernameAsync(long userid, [FromBody] string username)
		{
			var result = await _IProfileService.UpdateUsername(userid, username);
			if (result == null)
				return NotFound("User Not Found!");
			return Ok(result.Username);
		}
	}
}