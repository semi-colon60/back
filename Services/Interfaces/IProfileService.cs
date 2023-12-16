
namespace dotnet.Services.Interfaces
{
	public interface IProfileService
	{
		public Task<CommercialId> GetCommercialIdById(long id);
		public Task<CommercialId> UpdateName(long id, string name);
		public Task<CommercialId> UpdateSurname(long id, string surname);
		public Task<CommercialId> UpdateUsername(long id, string username);
		public Task<CommercialId> UpdateCommercialTitle(long id, string CommercialTitle);
		public Task<CommercialId> UpdatePhone(long id, string phone);
		public Task<CommercialId> UpdateEmail(long id, string email);

	}
}