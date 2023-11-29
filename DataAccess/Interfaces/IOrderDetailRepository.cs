using dotnet.DataAcces.Models;

namespace dotnet.DataAccess.Interfaces
{
	public interface IOrderDetailRepository
	{
		Task<OrderDetail?> GetByIdAsync(Int64 id);
		Task<IEnumerable<OrderDetail>> GetByOrderIdAsync(Int64 id);
		Task AddAsync(OrderDetail orderDetail);
		Task UpdateAsync(OrderDetail orderDetail);
		Task DeleteAsync(Int64 id);
	}
}