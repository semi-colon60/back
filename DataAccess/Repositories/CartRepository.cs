using dotnet.DataAccess.DbContexts;
using dotnet.DataAccess.Interfaces;
using dotnet.DataAccess.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Repositories
{
	public class CartRepository : ICartItemsRepository
	{
		public readonly ApplicationContext Context;
		
		public CartRepository(ApplicationContext context)
		{
			Context = context
				?? throw new ArgumentNullException(nameof(context));
		}

        public async Task<IEnumerable<CartItems>> GetCartItems(Int64 id)
        {
			try
			{
				return await Context.CartItem.Where(c => c.CommercialID == id).ToListAsync();;
			}
			catch (System.Exception)
			{
				Console.WriteLine("Cart Repository Error\n\n");
				throw;
			}
           // throw new NotImplementedException();
        }
    }
}