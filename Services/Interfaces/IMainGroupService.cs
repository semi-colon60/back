using dotnet.DataAccess.Models;

namespace dotnet.Services.Interfaces
{
    public interface IMainGroupService
    {
        MainGroup GetById(int id);
        IEnumerable<MainGroup> GetAll();
        void Add(MainGroup mainGroup);
        void Update(MainGroup mainGroup);
        void Delete(int id);

		// Additional get methods
		MainGroup GetByName(string name);

		// Additional business logic methods
    }
}