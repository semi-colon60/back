using dotnet.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
	[ApiController]
	public class AddMaterialController : ControllerBase
	{
		private readonly IAddMaterialService _addMaterialService;

		public AddMaterialController(IAddMaterialService addMaterialService)
		{
			_addMaterialService = addMaterialService;
		}

		[HttpPost("api/AddMaterial/AddMaterial")]
		public async Task<IActionResult> AddMaterialAsync([FromBody]Material material)
		{
			// System.Console.WriteLine(material.Count + "	" + material.Length);
			try
			{
				await _addMaterialService.AddMaterialAsync(material);
				return Ok();
			} catch (Exception e) {
				return BadRequest(e.Message);
			}

		}

		[HttpGet("api/AddMaterial/MainGroups")]
		public async Task<IActionResult> GetAllMainGroups()
		{
			var result = await _addMaterialService.GetAllMainGroups();
			if (result == null)
				return NotFound("List is empty!");
			return Ok(result);
		}

		[HttpGet("api/AddMaterial/SubGroups/{id}")]
		public async Task<IActionResult> GetAllSubGroupsOfMainGroup(long id)
		{
			var result = await _addMaterialService.GetAllSubGroupsOfMainGroup(id);
			if (result == null)
				return NotFound("List is empty!");
			return Ok(result);
		}
	}
}