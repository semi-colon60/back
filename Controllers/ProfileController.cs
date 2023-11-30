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
		public async Task<IActionResult> AddAddressAsync()
		{
			throw new NotImplementedException();
		}

		[HttpPut("Profile/UpdateAddressInfo")]
		public async Task<IActionResult> UpdateAdressInfosAsync()
		{
			throw new NotImplementedException();
		}
	}
}