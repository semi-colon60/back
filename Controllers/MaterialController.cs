using dotnet.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
    public class MaterialController : ControllerBase
    {

		private readonly IMaterialService _materialService;

		public MaterialController(IMaterialService materialService)
		{
			_materialService = materialService;
		}

		[HttpPost]
        public async Task<IActionResult> AddAsync(Material material)
        {
            await _materialService.AddAsync(material);
			return Ok();
        }

		[HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
			try
			{
				await _materialService.DeleteAsync(id);
				return Ok();
			} catch (ArgumentNullException e) {
				return NotFound(e.Message);
			}
        }

		[HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
			var result = await _materialService.GetAllAsync();
			if (result == null)
				return NotFound();
			return Ok(result);
        }

		[HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            try
			{
				var result = await _materialService.GetByIdAsync(id);
				return Ok(result);
			} catch (ArgumentNullException e) {
				return NotFound(e.Message);
			}
        }

		[HttpGet("{mainGroupId}")]
        public async Task<IActionResult> GetByMainGroupIdAsync(int mainGroupId)
        {
            var result = await _materialService.GetByMainGroupIdAsync(mainGroupId);
			if (result == null)
				return NotFound();
			return Ok(result);
        }

		[HttpGet("{subGroupId}")]
        public async Task<IActionResult> GetBySubGroupIdAsync(int subGroupId)
        {
            var result = await _materialService.GetBySubGroupIdAsync(subGroupId);
			if (result == null)
				return NotFound();
			return Ok(result);
        }

		[HttpGet]
        public async Task<IActionResult> GetByUnitAsync(UnitType unit)
        {
            var result = await _materialService.GetByUnitAsync(unit);
			if (result == null)
				return NotFound();
			return Ok(result);
        }

		[HttpPut]
        public async Task<IActionResult> UpdateAsync(Material material)
        {
            await _materialService.UpdateAsync(material);
			return Ok();
        }
    }
}