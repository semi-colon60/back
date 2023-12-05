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
		public async Task<IActionResult> ChangeAddressAsync(long id)
		{
			throw new NotImplementedException();
		}

		[HttpPost("Cart/AddOrder")]
		public async Task<IActionResult> AddOrderAsync(Order order)
		{
			throw new NotImplementedException();
		}
	}
}