// using dotnet.Services.Interfaces;
// using Microsoft.AspNetCore.Mvc;

// namespace dotnet.Controllers
// {
// 	[Route("api/[controller]/[action]")]
// 	[ApiController]
// 	public class SubGroupController : ControllerBase
// 	{
// 		private readonly ISubGroupService _subGroupService;

// 		public SubGroupController(ISubGroupService subGroupService)
// 		{
// 			_subGroupService = subGroupService;
// 		}

// 		[HttpPost]
//         public async Task<IActionResult> AddAsync(SubGroup subGroup)
//         {
//             await _subGroupService.AddAsync(subGroup);
// 			return Ok();
//         }

// 		[HttpDelete]
//         public async Task<IActionResult> DeleteAsync(int id)
//         {
// 			try
// 			{
// 	            await _subGroupService.DeleteAsync(id);
// 				return Ok();
// 			} catch (ArgumentNullException e) {
// 				return NotFound(e.Message);
// 			}
//         }

// 		[HttpGet("~/GetAllAsync")]
//         public async Task<IActionResult> GetAllAsync()
//         {
//             var result = await _subGroupService.GetAllAsync();
// 			if (result == null)
// 				return NotFound();
// 			return Ok(result);
//         }

// 		[HttpGet("~/GetByIdAsync")]
//         public async Task<IActionResult> GetByIdAsync(int id)
//         {
//             try
// 			{
// 	            var result = await _subGroupService.GetByIdAsync(id);
// 				return Ok(result);
// 			} catch (ArgumentNullException e) {
// 				return NotFound(e.Message);
// 			}
//         }

// 		[HttpGet("~/GetByMainGroupIdAsync")]
//         public async Task<IActionResult> GetByMainGroupIdAsync(int mainGroupId)
//         {
//             var result = await _subGroupService.GetByMainGroupIdAsync(mainGroupId);
// 			if (result == null)
// 				return NotFound();
// 			return Ok(result);
//         }

// 		[HttpGet("~/GetByNameAsync")]
//         public async Task<IActionResult> GetByNameAsync(string name)
//         {
//             try
// 			{
// 	            var result = await _subGroupService.GetByNameAsync(name);
// 				return Ok(result);
// 			} catch (ArgumentNullException e) {
// 				return NotFound(e.Message);
// 			}
//         }

// 		[HttpPut]
//         public async Task<IActionResult> UpdateAsync(SubGroup subGroup)
//         {
//             await _subGroupService.UpdateAsync(subGroup);
// 			return Ok();
//         }
//     }
// }