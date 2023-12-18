using dotnet.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ReviewOrderController : ControllerBase
	{

		private readonly IReviewOrderService _IReviewOrderService;

		public ReviewOrderController(IReviewOrderService reviewOrderService)
		{
			_IReviewOrderService = reviewOrderService;
		}

		[HttpGet("Orders")]
		public async Task<IActionResult> GetAllOrdersAsync()
		{
			var result = await _IReviewOrderService.GetAllOrdersAsync();
			if (result == null)
				return NotFound("List is empty!");
			return Ok(result);
		}

	}
}