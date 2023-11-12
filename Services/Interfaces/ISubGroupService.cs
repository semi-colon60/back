using dotnet.DataAccess.Models;

namespace dotnet.Services.Interfaces
{
    public interface ISubGroupService
    {
        SubGroup GetById(int id);
        IEnumerable<SubGroup> GetAll();
        void Add(SubGroup subGroup);
        void Update(SubGroup subGroup);
        void Delete(int id);

        // Additional get methods
		SubGroup GetByName(string name);
        IEnumerable<SubGroup> GetByMainGroupId(int mainGroupId);

        // Additional business logic methods
    }
}
