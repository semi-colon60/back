using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace dotnet.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AddUserController : ControllerBase
	{
		[HttpPost("AddUser")]
		public async Task<IActionResult> AddUserAsync(CommercialId commercialId)
		{
			throw new NotImplementedException();
		}
	}
}