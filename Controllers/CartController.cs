using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CartController : ControllerBase
	{
		[HttpGet("Cart")]
		public async Task<IActionResult> GetCartAsync()
		{
			throw new NotImplementedException();
		}

		[HttpPut("Cart/ChangeAddress")]
		public async Task<IActionResult> ChangeAddressAsync()
		{
			throw new NotImplementedException();
		}	
	}
}