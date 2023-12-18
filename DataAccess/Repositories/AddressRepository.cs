using dotnet.DataAccess.DbContexts;
using dotnet.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Repositories
{
    public class AddressRepository : IAddressRepository
    {
		private readonly ApplicationContext _context;
        public AddressRepository(ApplicationContext context)
        {
			_context = context;
        }

        public async Task AddAdressAsync(Address address)
        {
            await _context.Addresses.AddAsync(address);
			await _context.SaveChangesAsync();
        }

		public async Task<IEnumerable<Address>> GetAddressesByCommercialId(long id)
		{
			return await _context.Addresses.Where(a => a.CommercialId == id).ToListAsync();
		}

		public async Task<Address?> GetById(long id)
		{
			return await _context.Addresses.FirstOrDefaultAsync(a => a.AddressId == id);
		}
    }
}