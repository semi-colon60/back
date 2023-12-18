using dotnet.DataAccess.DbContexts;
using dotnet.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Repositories
{
	public class CommercialIdRepository : ICommercialIdRepository
	{
		public readonly ApplicationContext Context;
		
		public CommercialIdRepository(ApplicationContext context)
		{
			Context = context
				?? throw new ArgumentNullException(nameof(context));
		}

		public async Task AddAsync(CommercialId commercialId)
		{
			await Context.CommercialIds.AddAsync(commercialId);
			await Context.SaveChangesAsync();
		}

		public async Task DeleteAsync(Int64 id)
		{
			var commercialId = await GetByIdAsync(id);
			if (commercialId != null)
			{
				Context.CommercialIds.Remove(commercialId);
				await Context.SaveChangesAsync();
			}
			else 
				throw new ArgumentNullException(nameof(commercialId));
		}

		// Update uses a synchronous method.
		public async Task UpdateAsync(CommercialId commercialId)
		{
			Context.CommercialIds.Update(commercialId);
			await Context.SaveChangesAsync();
		}

		public async Task<CommercialId> GetByIdAsync(Int64 id)
		{
			return await Context.CommercialIds.FirstOrDefaultAsync(c => c.CommercialID == id)
				?? throw new ArgumentNullException(nameof(id));
		}

		public async Task<IEnumerable<CommercialId>> GetAllAsync()
		{
			return await Context.CommercialIds.ToListAsync();
		}

		public async Task<IEnumerable<CommercialId>> GetByCommercialTitleAsync(string commercialTitle)
		{
			return await Context.CommercialIds.Where(c => c.CommercialTitle == commercialTitle).ToListAsync();
		}

		public async Task<CommercialId?> GetByEmailAsync(string email)
		{
			return await Context.CommercialIds.FirstOrDefaultAsync(c => c.Email == email);
		}

		public async Task<IEnumerable<CommercialId>> GetByNameAndSurnameAsync(string name, string surname)
		{
			return await Context.CommercialIds.Where(c => c.Name == name && c.Surname == surname).ToListAsync();
		}

		public async Task<IEnumerable<CommercialId>> GetByNameAsync(string name)
		{
			return await Context.CommercialIds.Where(c => c.Name == name).ToListAsync();
		}

		public async Task<IEnumerable<CommercialId>> GetByPhoneAsync(string phone)
		{
			return await Context.CommercialIds.Where(c => c.Phone == phone).ToListAsync();
		}

		public async Task<IEnumerable<CommercialId>> GetBySurnameAsync(string surname)
		{
			return await Context.CommercialIds.Where(c => c.Surname == surname).ToListAsync();
		}

		public async Task<CommercialId?> GetByUsernameAsync(string username)
		{
			return await Context.CommercialIds.FirstOrDefaultAsync(c => c.Username == username);
		}

	}
}