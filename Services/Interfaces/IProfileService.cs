using dotnet.Services.DTOs;

namespace dotnet.Services.Interfaces
{
	public interface IProfileService
	{
		public Task<CommercialId> GetCommercialIdById(long id);
	}
}