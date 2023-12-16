namespace dotnet.DataAccess.Interfaces
{
	public interface ICartItemsRepository
	{
		Task<IEnumerable<CartItems>> GetCartItems(Int64 id);
		
	}
}
