
namespace dotnet.Services.Interfaces
{
	public interface IProfileService
	{
		public Task<CommercialId> GetCommercialIdById(long id);
		public Task<CommercialId> UpdatePhone(long id, string phone);
		public Task<CommercialId> UpdateEmail(long id, string email);
		public Task<CommercialId> UpdateUsername(long id, string username);

	}
}