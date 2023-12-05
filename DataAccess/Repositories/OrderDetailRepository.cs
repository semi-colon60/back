using dotnet.DataAcces.Models;
using dotnet.DataAccess.DbContexts;
using dotnet.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
		private readonly ApplicationContext _context;

        public OrderDetailRepository(ApplicationContext context)
        {
			_context = context;
        }

        public async Task AddAsync(OrderDetail orderDetail)
        {
            await _context.OrderDetails.AddAsync(orderDetail);
			await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
			var orderDetail = await GetByIdAsync(id);
			if (orderDetail != null)
			{
            	_context.OrderDetails.Remove(orderDetail);
				await _context.SaveChangesAsync();
			}
			else
				throw new ArgumentNullException(nameof(orderDetail));
        }

        public async Task<OrderDetail?> GetByIdAsync(Int64 id)
        {
            return await _context.OrderDetails.FirstOrDefaultAsync(c => c.OrderDetailId == id);
        }

        public async Task<IEnumerable<OrderDetail>> GetByOrderIdAsync(long id)
        {
            return await _context.OrderDetails.Where(c => c.OrderId == id).ToListAsync();
        }

        public async Task UpdateAsync(OrderDetail orderDetail)
        {
            _context.OrderDetails.Update(orderDetail);
			await _context.SaveChangesAsync();
        }
    }
}