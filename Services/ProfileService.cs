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
		public async Task<CommercialId> UpdateName(long id, string name)
		{
			CommercialId newCommercialId = await _commercialIdRepository.GetByIdAsync(id);
			newCommercialId.Name = name;

			await _commercialIdRepository.UpdateAsync(newCommercialId);
			return newCommercialId;
		}
		public async Task<CommercialId> UpdateSurname(long id, string surname)
		{
			CommercialId newCommercialId = await _commercialIdRepository.GetByIdAsync(id);
			newCommercialId.Surname = surname;

			await _commercialIdRepository.UpdateAsync(newCommercialId);
			return newCommercialId;
		}
		public async Task<CommercialId> UpdateUsername(long id, string username)
		{
			CommercialId newCommercialId = await _commercialIdRepository.GetByIdAsync(id);
			newCommercialId.Username = username;

			await _commercialIdRepository.UpdateAsync(newCommercialId);
			return newCommercialId;
		}
		public async Task<CommercialId> UpdateCommercialTitle(long id, string CommercialTitle)
		{
			CommercialId newCommercialId = await _commercialIdRepository.GetByIdAsync(id);
			newCommercialId.CommercialTitle = CommercialTitle;

			await _commercialIdRepository.UpdateAsync(newCommercialId);
			return newCommercialId;
		}
		public async Task<CommercialId> UpdatePhone(long id, string phone)
		{
			CommercialId newCommercialId = await _commercialIdRepository.GetByIdAsync(id);
			newCommercialId.Phone = phone;

			await _commercialIdRepository.UpdateAsync(newCommercialId);
			return newCommercialId;
		}
		public async Task<CommercialId> UpdateEmail(long id, string email)
		{
			CommercialId newCommercialId = await _commercialIdRepository.GetByIdAsync(id);
			newCommercialId.Email = email;

			await _commercialIdRepository.UpdateAsync(newCommercialId);
			return newCommercialId;
		}
	
	}
}