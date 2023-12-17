using dotnet.DataAccess.DbContexts;
using dotnet.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.Repositories
{
	public class MaterialRepository : IMaterialRepository
	{
		private readonly ApplicationContext Context;

		public MaterialRepository(ApplicationContext context)
		{
			Context = context
				?? throw new ArgumentNullException(nameof(context));
		}

		public async Task AddAsync(Material material)
		{
			await Context.Materials.AddAsync(material);
			await Context.SaveChangesAsync();
		}

		public async Task DeleteAsync(long id)
		{
			var material = await GetByIdAsync(id);
			if (material != null)
			{
				Context.Materials.Remove(material);
				await Context.SaveChangesAsync();
			}
			else
				throw new ArgumentNullException(nameof(material));
		}

		public async Task UpdateAsync(Material material)
		{
			Context.Materials.Update(material);
			await Context.SaveChangesAsync();
		}
		public async Task<IEnumerable<Material>> GetAllAsync()
		{
			return await Context.Materials.ToListAsync();
		}

		public async Task<Material> GetByIdAsync(long id)
		{
			return await Context.Materials.FirstOrDefaultAsync(m => m.MaterialId == id)
				?? throw new ArgumentNullException(nameof(id));
		}

		public async Task<IEnumerable<Material>> GetByMainGroupIdAsync(long mainGroupId)
		{
			return await Context.Materials.Where(m => m.MainGroupId == mainGroupId).ToListAsync();
		}

		public async Task<IEnumerable<Material>> GetBySubGroupIdAsync(long subGroupId)
		{
			return await Context.Materials.Where(m => m.SubGroupId == subGroupId).ToListAsync();
		}

		public async Task<IEnumerable<Material>> GetByUnitAsync(UnitType unit)
		{
			return await Context.Materials.Where(m => m.Unit == unit).ToListAsync();
		}
	}
}