using dotnet.DataAccess.DbContexts;
using dotnet.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Repositories
{
	public class CartItemRepository : ICartItemRepository
	{
		private readonly ApplicationContext _context;
		public CartItemRepository(ApplicationContext context)
		{
			_context = context;
		}

		public async Task AddCartItem(CartItem cartItem)
		{
			await _context.CartItems.AddAsync(cartItem);
			await _context.SaveChangesAsync();
		}

		public async Task<CartItem> DeleteCartItem(CartItem cartItem)
		{
			if (cartItem != null)
			{
				_context.CartItems.Remove(cartItem);
				await _context.SaveChangesAsync();
				return cartItem;
			}
			else
				throw new ArgumentNullException(nameof(cartItem));
		}

		public async Task<CartItem> DeleteCartItem(long materialId, long commercialId)
		{
			CartItem cartItem = await GetCartItem(materialId, commercialId);
			return await DeleteCartItem(cartItem);
		}

		public async Task<IEnumerable<CartItem>> GetAllCartByCommercialId(long commercialId)
		{
			return await _context.CartItems.Where(ci => ci.CommercialId == commercialId).ToListAsync();
		}

		public async Task<IEnumerable<CartItem>> GetAllUsersWhoPurchasedThisMaterial(long materialId)
		{
			return await _context.CartItems.Where(ci => ci.MaterialId == materialId).ToListAsync();
		}

		public async Task<CartItem> GetCartItem(long materialId, long commercialId)
		{
			return await _context.CartItems.FirstOrDefaultAsync(ci => ci.MaterialId == materialId && ci.CommercialId == commercialId)
				?? throw new ArgumentNullException(nameof(materialId));
		}

		public async Task<IEnumerable<CartItem>> ReadAll()
		{
			return await _context.CartItems.ToListAsync();
		}

		public Task<CartItem> UpdateCartItem(CartItem cartItem)
		{
			_context.CartItems.Update(cartItem);
			_context.SaveChanges();
			return Task.FromResult(cartItem);
		}
	}
}