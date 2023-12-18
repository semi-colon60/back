// using dotnet.Services.temp.Interfaces;
// using Microsoft.AspNetCore.Mvc;

// namespace dotnet.Controllers.temp {

// 	[Route("api/[controller]/[action]")]
// 	[ApiController]
// 	public class CommercialIdController : ControllerBase {
//         private readonly ICommercialIdService _commercialIdService;

//         public CommercialIdController(ICommercialIdService commercialIdService)
// 		{
// 			_commercialIdService = commercialIdService;
// 		}

// 		[HttpGet("{id}")]
// 		public async Task<IActionResult> GetByIdAysnc(int id)
// 		{
// 			try
// 			{
// 				var result = await _commercialIdService.GetByIdAsync(id);
// 				return Ok(result);
// 			} catch(ArgumentNullException e) {
// 				return NotFound(e.Message);
// 			}
// 		}

// 		[HttpGet]
// 		public async Task<IActionResult> GetAllAsync()
// 		{
// 			var result = await _commercialIdService.GetAllAsync();
// 			if (result == null)
// 				return NotFound();
// 			return Ok(result);
// 		}

// 		[HttpPost]
// 		public async Task<IActionResult> AddAsync(CommercialId commercialId)
// 		{
// 			try
// 			{
// 				await _commercialIdService.AddAsync(commercialId);
// 				return Ok();
// 			} catch (Exception e) {
// 				return BadRequest(e.Message);
// 			}
// 		}

// 		[HttpPut]
// 		public async Task<IActionResult> UpdateAsync(CommercialId commercialId)
// 		{
// 			try
// 			{
// 				await _commercialIdService.UpdateAsync(commercialId);
// 				return Ok();
// 			} catch (Exception e) {
// 				return BadRequest(e.Message);
// 			}
// 		}

// 		[HttpDelete("{id}")]
// 		public async Task<IActionResult> DeleteAsync(int id)
// 		{
// 			try
// 			{
// 				await _commercialIdService.DeleteAsync(id);
// 				return Ok();
// 			} catch (ArgumentNullException e) {
// 				return NotFound(e.Message);
// 			}
// 		}

// 		[HttpGet]
// 		public async Task<IActionResult> GetByNameAsync(string name)
// 		{
// 			var result = await _commercialIdService.GetByNameAsync(name);
// 			if (result == null)
// 				return NotFound();
// 			return Ok(result);	
// 		}

// 		[HttpGet]
// 		public async Task<IActionResult> GetBySurnameAsync(string surname)
// 		{
// 			var result = await _commercialIdService.GetBySurnameAsync(surname);
// 			if (result == null)
// 				return NotFound();
// 			return Ok(result);	
// 		}

// 		[HttpGet]
// 		public async Task<IActionResult> GetByNameAndSurnameAsync(string name, string surname)
// 		{
// 			var result = await _commercialIdService.GetByNameAndSurnameAsync(name, surname);
// 			if (result == null)
// 				return NotFound();
// 			return Ok(result);	
// 		}

// 		[HttpGet]
// 		public async Task<IActionResult> GetByCommercialTitleAsync(string commercialTitle)
// 		{
// 			var result = await _commercialIdService.GetByCommercialTitleAsync(commercialTitle);
// 			if (result == null)
// 				return NotFound();
// 			return Ok(result);	
// 		}

// 		[HttpGet]
// 		public async Task<IActionResult> GetByPhoneAsync(string phone)
// 		{
// 			var result = await _commercialIdService.GetByPhoneAsync(phone);
// 			if (result == null)
// 				return NotFound();
// 			return Ok(result);	
// 		}

// 		[HttpGet]
// 		public async Task<IActionResult> GetByEmailAsync(string email)
// 		{
// 			await _commercialIdService.GetByEmailAsync(email);
// 			return Ok();
// 		}

		
// 		[HttpGet]
// 		public async Task<IActionResult> GetByUsernameAsync(string username)
// 		{
// 			try
// 			{
// 				await _commercialIdService.GetByUsernameAsync(username);
// 				return Ok();	
// 			} catch(ArgumentNullException e) {
// 				return NotFound(e.Message);
// 			}
// 		}
// 	}
// }