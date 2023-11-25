using dotnet.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class MainGroupController : ControllerBase
	{

		private readonly IMainGroupService _mainGroupService;

		public MainGroupController(IMainGroupService mainGroupService)
		{
			_mainGroupService = mainGroupService;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			try
			{
				var result = await _mainGroupService.GetByIdAsync(id);
				return Ok(result);
			} catch (ArgumentNullException e) {
				return NotFound(e.Message);
			}
		}

		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var result = await _mainGroupService.GetAllAsync();
			if (result == null)
				return NotFound();
			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> AddAsync(MainGroup mainGroup)
		{
			await _mainGroupService.AddAsync(mainGroup);
			return Ok();
		}

		[HttpPut]
		public async Task<IActionResult> UpdateAsync(MainGroup mainGroup)
		{
			await _mainGroupService.UpdateAsync(mainGroup);
			return Ok();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			try 
			{
				await _mainGroupService.DeleteAsync(id);
				return Ok();
			} catch (ArgumentNullException e)
			{
				return NotFound(e.Message);
			}
		}

		[HttpGet]
		public async Task<IActionResult> GetByNameAsync(string name)
		{
			try
			{
				var result = await _mainGroupService.GetByNameAsync(name);
				return Ok(result);
			} catch (ArgumentNullException e) {
				return NotFound(e.Message);
			}
		}
	}
}