namespace dotnet.DataAccess.Interfaces
{
	public interface IOrderRepository
	{
		Task<Order?> GetByIdAsync(Int64 id);
		Task<IEnumerable<Order>> GetAllAsync();
		Task AddAsync(Order order);
		Task UpdateAsync(Order order);
		Task DeleteAsync(Int64 id);
		Task UpdateAddressAsync(long addressId, long orderId);

		//Additional add methods
		Task<Order?> GetByCommercialIdAsync(Int64 id);
	}
}