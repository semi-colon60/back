using dotnet.DataAccess.DbContexts;
using dotnet.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
		private readonly ApplicationContext _context;

		public OrderRepository (ApplicationContext context)
		{
			_context = context
				?? throw new ArgumentNullException(nameof(context));
		}

        public async Task AddAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
			await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var order = await GetByIdAsync(id);
			if (order != null)
			{
				_context.Orders.Remove(order);
				await _context.SaveChangesAsync();
			}
			else
				throw new ArgumentNullException(nameof(order));
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
			return await _context.Orders.ToListAsync();
        }

        public async Task<Order?> GetByCommercialIdAsync(long id)
        {
            return await _context.Orders.FirstOrDefaultAsync(c => c.CommercialId == id);
        }

        public async Task<Order?> GetByIdAsync(long id)
        {
            return await _context.Orders.FirstOrDefaultAsync(c => c.OrderId == id);
        }

        public async Task UpdateAddressAsync(long addressId, long orderId)
        {
            var entityToUpdate = await GetByIdAsync(orderId);

            if (entityToUpdate != null)
            {
                entityToUpdate.AddressId = addressId;

                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Order order)
        {
            _context.Orders.Update(order);
			await _context.SaveChangesAsync();
        }
    }
}