using dotnet.Services.DTOs;

namespace dotnet.Services.Interfaces
{
	public interface ICartService
	{
		public Task<IEnumerable<CartItem>> GetCartItems(Int64 id);

		public Task<IEnumerable<CartItemInfosDTO>> GetCartItemInfos(Int64 id);
	}
}