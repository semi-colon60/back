// using dotnet.DataAccess.Interfaces;
// using dotnet.Services.Interfaces;

// namespace dotnet.Services
// {
//     public class SubGroupService : ISubGroupService
//     {

// 		private readonly ISubGroupRepository _subGroupRepository;

// 		public SubGroupService(ISubGroupRepository subGroupRepository)
// 		{
// 			_subGroupRepository = subGroupRepository;
// 		}

//         public async Task AddAsync(SubGroup subGroup)
//         {
//             await _subGroupRepository.AddAsync(subGroup);
//         }

//         public async Task DeleteAsync(int id)
//         {
//             await _subGroupRepository.DeleteAsync(id);
//         }

//         public async Task<IEnumerable<SubGroup>> GetAllAsync()
//         {
//             return await _subGroupRepository.GetAllAsync();
//         }

//         public async Task<SubGroup> GetByIdAsync(int id)
//         {
//             return await _subGroupRepository.GetByIdAsync(id);
//         }

//         public async Task<IEnumerable<SubGroup>> GetByMainGroupIdAsync(int mainGroupId)
//         {
//             return await _subGroupRepository.GetByMainGroupIdAsync(mainGroupId);
//         }

//         public async Task<SubGroup> GetByNameAsync(string name)
//         {
//             return await _subGroupRepository.GetByNameAsync(name);
//         }

//         public async Task UpdateAsync(SubGroup subGroup)
//         {
//             await _subGroupRepository.UpdateAsync(subGroup);
//         }
//     }
// }