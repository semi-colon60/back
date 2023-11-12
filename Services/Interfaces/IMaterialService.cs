using dotnet.DataAccess.Models;

namespace dotnet.Services.Interfaces
{
    public interface IMaterialService
    {
        Material GetById(int id);
        IEnumerable<Material> GetAll();
        void Add(Material material);
        void Update(Material material);
        void Delete(int id);

        // Additional get methods
        IEnumerable<Material> GetByUnit(UnitType unit);
        IEnumerable<Material> GetByMainGroupId(int mainGroupId);
        IEnumerable<Material> GetBySubGroupId(int subGroupId);

		// Additional business logic methods
    }
}