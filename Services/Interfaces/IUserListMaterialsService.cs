using dotnet.Services.DTOs;

namespace dotnet.Services.Interfaces
{
	public interface IUserListMaterialsService
	{
		Task<IEnumerable<Material>> GetAllMaterialsAsync();
		Task<IEnumerable<Material>> GetMaterialsByMainGroupIdAsync(Int64 id);
		Task<IEnumerable<Material>> GetMaterialsBySubGroupIdAsync(Int64 id);
		Task<Material> AddMaterialToCart(Material material);
		Task<IEnumerable<MainGroup>> GetAllMainGroupsAsync();
		Task<IEnumerable<SubGroup>> GetSubGroupsByMainGroupId(Int64 id);
	}
}