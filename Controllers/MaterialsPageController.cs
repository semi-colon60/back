using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MaterialsPageController : ControllerBase
	{
		[HttpGet("Materials")]
		public async Task<IActionResult> GetAllMaterialsAsync()
		{
			throw new NotImplementedException();
		}

		[HttpGet("Materials/MainGroup/{id}")]
		public async Task<IActionResult> GetByMainGroupIdAsync(Int64 id)
		{
			throw new NotImplementedException();
		}

		[HttpGet("Materials/SubGroup/{id}")]
		public async Task<IActionResult> GetBySubGroupIdAsync(Int64 id)
		{
			throw new NotImplementedException();
		}

		[HttpPost("Materials/AddToCart")]
		public async Task<IActionResult> AddMaterialToCart(Material material)
		{
			throw new NotImplementedException();
		}
	}
}