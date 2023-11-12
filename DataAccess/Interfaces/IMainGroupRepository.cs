using dotnet.DataAccess.Models;

namespace dotnet.DataAccess.Interfaces
{
    public interface IMainGroupRepository
    {
        MainGroup GetById(int id);
        IEnumerable<MainGroup> GetAll();
        void Add(MainGroup mainGroup);
        void Update(MainGroup mainGroup);
        void Delete(int id);

		// Additional get methods
		MainGroup GetByName(string name);
    }
}
