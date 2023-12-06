using dotnet.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace dotnet.Controllers
{
	[Route("api/Admin/[controller]")]
	[ApiController]
	public class AddUserController : ControllerBase
	{
		private readonly IAddUserService _addUserService;
		public AddUserController(IAddUserService addUserService)
		{
			_addUserService = addUserService;
		}
		
         [HttpPost("")]
        public async Task<IActionResult> AddUser([FromBody] CommercialId commercialId)
        {
            
            try
            {
               await _addUserService.PushAsync(commercialId);
                return Ok(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error handling POST request\n");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}