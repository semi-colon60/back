// using dotnet.DataAccess.Interfaces;
// using dotnet.Services.Interfaces;

// namespace dotnet.Services
// {
// 	public class MainGroupService : IMainGroupService
// 	{
// 		private readonly IMainGroupRepository _mainGroupRepository;

// 		public MainGroupService(IMainGroupRepository mainGroupRepository)
// 		{
// 			_mainGroupRepository = mainGroupRepository;
// 		}

// 		public async Task<MainGroup> GetByIdAsync(int id)
// 		{
// 			return await _mainGroupRepository.GetByIdAsync(id);
// 		}
		
// 		public async Task<IEnumerable<MainGroup>> GetAllAsync()
// 		{
// 			return await _mainGroupRepository.GetAllAsync();
// 		}
		
// 		public async Task AddAsync(MainGroup mainGroup)
// 		{
// 			await _mainGroupRepository.AddAsync(mainGroup);
// 		}
		
// 		public async Task UpdateAsync(MainGroup mainGroup)
// 		{
// 			await _mainGroupRepository.UpdateAsync(mainGroup);
// 		}
		
// 		public async Task DeleteAsync(int id)
// 		{
// 			await _mainGroupRepository.DeleteAsync(id);
// 		}

// 		// Additional get methods
// 		public async Task<MainGroup> GetByNameAsync(string name)
// 		{
// 			return await _mainGroupRepository.GetByNameAsync(name);
// 		}
// 	}
// }