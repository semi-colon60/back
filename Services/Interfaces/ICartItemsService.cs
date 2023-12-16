using dotnet.Services.DTOs;

namespace dotnet.Services.Interfaces
{
	public interface ICartItemsService
	{
		public Task<IEnumerable<CartItems>> GetCartItems(Int64 id);

		public Task<IEnumerable<CartItemInfosDTO>> GetCartItemInfos(Int64 id);
	}
}