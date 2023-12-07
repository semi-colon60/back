using dotnet.DataAccess.Interfaces;
using dotnet.Services.Interfaces;

namespace dotnet.Services
{
    public class AddMaterialService : IAddMaterialService
    {
		private readonly IMainGroupRepository _mainGroupRepository;
		private readonly ISubGroupRepository _subGroupRepository;
        private readonly IMaterialRepository _materialRepository;
        public AddMaterialService(IMainGroupRepository mainGroupRepository, ISubGroupRepository subGroupRepository, IMaterialRepository materialRepository)
        {
			_mainGroupRepository = mainGroupRepository;
            _subGroupRepository = subGroupRepository;
            _materialRepository = materialRepository;
        }

        public async Task AddMaterialAsync(Material material)
        {
            await _materialRepository.AddAsync(material);
        }

        public async Task<IEnumerable<MainGroup>> GetAllMainGroups()
		{
			return await _mainGroupRepository.GetAllAsync();
		}

        public async Task<IEnumerable<SubGroup>> GetAllSubGroupsOfMainGroup(long id)
		{
			return await _subGroupRepository.GetByMainGroupIdAsync(id);
		}
    }
}