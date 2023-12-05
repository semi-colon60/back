using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProfileController : ControllerBase
	{
		[HttpGet("Profile")]
		public async Task<IActionResult> GetProfileAsync()
		{
			throw new NotImplementedException();
		}

		[HttpPost("Profile/AddAddress")]
		public async Task<IActionResult> AddAddressAsync(Address address)
		{
			throw new NotImplementedException();
		}

		[HttpPut("Profile/UpdateAddressInfo")]
		public async Task<IActionResult> UpdateAdressInfosAsync(Address address)
		{
			throw new NotImplementedException();
		}

		[HttpPut("Profile/UpdatePhone")]
		public async Task<IActionResult> UpdatePhoneAsync(string phone)
		{
			throw new NotImplementedException();
		}

		[HttpPut("Profile/UpdateEmail")]
		public async Task<IActionResult> UpdateEmailAsync(string email)
		{
			throw new NotImplementedException();
		}

		[HttpPut("Profile/UpdateUsername")]
		public async Task<IActionResult> UpdateUsernameAsync(string username)
		{
			throw new NotImplementedException();
		}
	}
}