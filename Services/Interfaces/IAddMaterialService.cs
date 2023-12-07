namespace dotnet.Services.Interfaces
{
	public interface IAddMaterialService
	{
		Task AddMaterialAsync(Material material);
		Task<IEnumerable<MainGroup>> GetAllMainGroups();
        Task<IEnumerable<SubGroup>> GetAllSubGroupsOfMainGroup(long id);
	}
}