using dotnet.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MaterialsPageController : ControllerBase
	{
		private readonly IUserListMaterialsService _userListMaterialsService;

		public MaterialsPageController(IUserListMaterialsService userListMaterialsService)
		{
			_userListMaterialsService = userListMaterialsService;
		}

		[HttpGet("Materials")]
		public async Task<IActionResult> GetAllMaterialsAsync()
		{
			IEnumerable<Material> materials = await _userListMaterialsService.GetAllMaterialsAsync();
			if (materials == null)
				return NotFound("Materials Not Found!");
			return Ok(materials);
		}

		[HttpGet("Materials/MainGroup/{id}")]
		public async Task<IActionResult> GetMaterialsByMainGroupIdAsync(Int64 id)
		{
			IEnumerable<Material> materials = await _userListMaterialsService.GetMaterialsByMainGroupIdAsync(id);
			if (materials == null)
				return NotFound("There is no material with this MainGroupId!");
			return Ok(materials);
		}

		[HttpGet("Materials/SubGroup/{id}")]
		public async Task<IActionResult> GetMaterialsBySubGroupIdAsync(Int64 id)
		{
			IEnumerable<Material> materials = await _userListMaterialsService.GetMaterialsBySubGroupIdAsync(id);
			if (materials == null)
				return NotFound("There is no material with this SubGroupId!");
			return Ok(materials);
		}

		[HttpPost("Cart/AddToCart")]
		public async Task<IActionResult> AddMaterialToCart([FromBody] CartItem cartItem)
		{
			if (cartItem == null)
				return BadRequest("CartItem is null!");
			CartItem cartItemFromDb = await _userListMaterialsService.AddMaterialToCart(cartItem);
			return Ok(cartItemFromDb);
		}

		[HttpGet("Cart/GetCartTotalValues/{id}")]
		public async Task<IActionResult> GetCartItemsByUserId(Int64 id)
		{
			return Ok(await _userListMaterialsService.GetTotals(id));
		}

		[HttpGet("MainGroups")]
		public async Task<IActionResult> GetAllMainGroupsAsync()
		{
			IEnumerable<MainGroup> mainGroups = await _userListMaterialsService.GetAllMainGroupsAsync();
			if (mainGroups == null)
				return NotFound("MainGroups Not Found!");
			return Ok(mainGroups);
		}

		[HttpGet("SubGroups/{id}")]
		public async Task<IActionResult> GetSubGroupsByMainGroupId(Int64 id)
		{
			IEnumerable<SubGroup> subGroups = await _userListMaterialsService.GetSubGroupsByMainGroupId(id);
			if (subGroups == null)
				return NotFound("There is no SubGroup with this MainGroupId!");
			return Ok(subGroups);
		}
	}
}