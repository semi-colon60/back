using dotnet.DataAccess.Interfaces;
using dotnet.Services.Interfaces;

namespace dotnet.Services {
	public class ProfileService : IProfileService
	{
		private readonly ICommercialIdRepository _commercialIdRepository;

		public ProfileService(ICommercialIdRepository commercialIdRepository)
		{
			_commercialIdRepository = commercialIdRepository;
		}
		public async Task<CommercialId> GetCommercialIdById(long id)
		{
			// CommercialId CommercialId_ = await _commercialIdRepository.GetByIdAsync(id);
			// public CommercialId? _commercialId { get; set; } = null;
			var commercialId = await _commercialIdRepository.GetByIdAsync(id);


			return commercialId;
		}
	}
}