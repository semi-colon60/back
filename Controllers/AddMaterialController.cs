using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AddMaterialController : ControllerBase
	{
		[HttpPost("AddMaterial")]
		public async Task<IActionResult> AddMaterialAsync(Material material)
		{
			throw new NotImplementedException();
		}
	}
}