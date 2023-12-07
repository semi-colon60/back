using dotnet.DataAccess.Interfaces;
using dotnet.Services.DTOs;

namespace dotnet.Services.Interfaces
{
	public class UserListMaterialsService : IUserListMaterialsService
	{
		private readonly IMaterialRepository _materialRepository;
		private readonly IMainGroupRepository _mainGroupRepository;
		private readonly ISubGroupRepository _subGroupRepository;

		public UserListMaterialsService(IMaterialRepository materialRepository, IMainGroupRepository mainGroupRepository, ISubGroupRepository subGroupRepository)
		{
			_materialRepository = materialRepository;
			_mainGroupRepository = mainGroupRepository;
			_subGroupRepository = subGroupRepository;
		}

		public async Task<Material> AddMaterialToCart(Material material)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<MainGroup>> GetAllMainGroupsAsync()
		{
			return await _mainGroupRepository.GetAllAsync();
		}

		public async Task<IEnumerable<Material>> GetAllMaterialsAsync()
		{
			return await _materialRepository.GetAllAsync();
		}

		public async Task<IEnumerable<Material>> GetMaterialsByMainGroupIdAsync(long id)
		{
			return await _materialRepository.GetByMainGroupIdAsync(id);
		}

		public async Task<IEnumerable<Material>> GetMaterialsBySubGroupIdAsync(long id)
		{
			return await _materialRepository.GetBySubGroupIdAsync(id);
		}

		public async Task<IEnumerable<SubGroup>> GetSubGroupsByMainGroupId(long id)
		{
			return await _subGroupRepository.GetByMainGroupIdAsync(id);
		}
	}
}