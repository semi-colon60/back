namespace dotnet.DataAccess.Interfaces
{
	public interface ICartItemRepository
	{
		Task AddCartItem(CartItem cartItem);
		Task<CartItem> UpdateCartItem(CartItem cartItem);
		Task<CartItem> DeleteCartItem(CartItem cartItem);
		Task<CartItem> DeleteCartItem(Int64 materialId, Int64 commercialId);
		Task<CartItem> GetCartItem(Int64 materialId, Int64 commercialId);
		Task<IEnumerable<CartItem>> GetAllCartByCommercialId(Int64 commercialId);
		Task<IEnumerable<CartItem>> GetAllUsersWhoPurchasedThisMaterial(Int64 materialId);
		Task<IEnumerable<CartItem>> ReadAll();
	}
}