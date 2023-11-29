using dotnet.DataAccess.DbContexts;
using dotnet.DataAccess.Interfaces;
using dotnet.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Repositories
{
	public class MainGroupRepository : IMainGroupRepository
	{
		private readonly ApplicationContext Context;

		public MainGroupRepository(ApplicationContext context)
		{
			Context = context
				?? throw new ArgumentNullException(nameof(context));
		}

        public async Task AddAsync(MainGroup mainGroup)
        {
            await Context.MainGroups.AddAsync(mainGroup);
			await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var mainGroup = await GetByIdAsync(id);
			if (mainGroup != null)
			{
				Context.MainGroups.Remove(mainGroup);
				await Context.SaveChangesAsync();
			}
			else
				throw new ArgumentNullException(nameof(mainGroup));
        }

        public async Task<IEnumerable<MainGroup>> GetAllAsync()
        {
            return await Context.MainGroups.ToListAsync();
        }

        public async Task<MainGroup> GetByIdAsync(int id)
        {
            return await Context.MainGroups.FirstOrDefaultAsync(m => m.MainGroupId == id)
				?? throw new ArgumentNullException(nameof(id));
        }

        public async Task<MainGroup?> GetByNameAsync(string name)
        {
            return await Context.MainGroups.FirstOrDefaultAsync(m => m.Name == name);
        }

        public async Task UpdateAsync(MainGroup mainGroup)
        {
            Context.MainGroups.Update(mainGroup);
			await Context.SaveChangesAsync();
        }
    }
}