using dotnet.DataAccess.DbContexts;
using dotnet.DataAccess.Interfaces;
using dotnet.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Repositories
{
	public class SubGroupRepository : ISubGroupRepository
	{
		private readonly ApplicationContext Context;

		public SubGroupRepository(ApplicationContext context)
		{
			Context = context
				?? throw new ArgumentNullException(nameof(context));
		}

        public async Task AddAsync(SubGroup subGroup)
        {
			await Context.SubGroups.AddAsync(subGroup);
			await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
			var subGroup = await GetByIdAsync(id);
			if (subGroup != null)
			{
				Context.SubGroups.Remove(subGroup);
				await Context.SaveChangesAsync();
			}
			else
				throw new ArgumentNullException(nameof(subGroup));
		}

        public async Task UpdateAsync(SubGroup subGroup)
        {
			Context.SubGroups.Update(subGroup);
			await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<SubGroup>> GetAllAsync()
        {
			return await Context.SubGroups.ToListAsync();
        }

        public async Task<SubGroup> GetByIdAsync(int id)
        {
			return await Context.SubGroups.FirstOrDefaultAsync(m => m.SubGroupId == id)
				?? throw new ArgumentNullException(nameof(id));
        }

        public async Task<IEnumerable<SubGroup>> GetByMainGroupIdAsync(int mainGroupId)
        {
			return await Context.SubGroups.Where(m => m.MainGroupId == mainGroupId).ToListAsync();
        }

        public async Task<SubGroup?> GetByNameAsync(string name)
        {
			return await Context.SubGroups.FirstOrDefaultAsync(m => m.Name == name);
        }
    }
}