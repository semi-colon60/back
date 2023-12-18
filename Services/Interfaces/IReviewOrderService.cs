using dotnet.Services.DTOs;

namespace dotnet.Services.Interfaces
{
	public interface IReviewOrderService
	{
		public Task<IEnumerable<OrderDTO>> GetAllOrdersAsync();
	}
}