// using dotnet.DataAccess.Interfaces;
// using dotnet.Services.Interfaces;

// namespace dotnet.Services
// {
//     public class MaterialService : IMaterialService
//     {

// 		private readonly IMaterialRepository _materialRepository; 

// 		public MaterialService(IMaterialRepository materialRepository)
// 		{
// 			_materialRepository = materialRepository;
// 		}

//         public async Task AddAsync(Material material)
//         {
//             await _materialRepository.AddAsync(material);
//         }

//         public async Task DeleteAsync(int id)
//         {
//             await _materialRepository.DeleteAsync(id);
//         }

//         public async Task<IEnumerable<Material>> GetAllAsync()
//         {
//             return await _materialRepository.GetAllAsync();
//         }

//         public async Task<Material> GetByIdAsync(int id)
//         {
//             return await _materialRepository.GetByIdAsync(id);
//         }

//         public async Task<IEnumerable<Material>> GetByMainGroupIdAsync(int mainGroupId)
//         {
//             return await _materialRepository.GetByMainGroupIdAsync(mainGroupId);
//         }

//         public async Task<IEnumerable<Material>> GetBySubGroupIdAsync(int subGroupId)
//         {
//             return await _materialRepository.GetBySubGroupIdAsync(subGroupId);
//         }

//         public async Task<IEnumerable<Material>> GetByUnitAsync(UnitType unit)
//         {
//             return await _materialRepository.GetByUnitAsync(unit);
//         }

//         public async Task UpdateAsync(Material material)
//         {
//             await _materialRepository.UpdateAsync(material);
//         }
//     }
// }