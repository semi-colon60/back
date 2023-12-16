using Microsoft.AspNetCore.Mvc;
using dotnet.Services.Interfaces;


namespace dotnet.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CartController : ControllerBase
	{
		private readonly ICartItemsService _CartItemService;

		public CartController(ICartItemsService cartItemsService)
		{
			_CartItemService = cartItemsService;
		}

		[HttpGet("Cart/{id}")]
		public async Task<IActionResult> GetCartAsync(int id)
		{
			var result =  await _CartItemService.GetCartItemInfos(id);
			if(result == null)
				return NotFound();
			return Ok(result);
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