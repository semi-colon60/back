using dotnet.Services.DTOs;

namespace dotnet.Services.Interfaces
{
	public interface IAddUserService
	{
		public Task PushAsync(CommercialId commercialId);
	}
}