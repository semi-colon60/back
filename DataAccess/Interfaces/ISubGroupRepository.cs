using dotnet.DataAccess.Models;

namespace dotnet.DataAccess.Interfaces
{
	public interface ISubGroupRepository
	{
		SubGroup GetById(int id);
		IEnumerable<SubGroup> GetAll();
		void Add(SubGroup subGroup);
		void Update(SubGroup subGroup);
		void Delete(int id);

		// Additional get methods
		SubGroup GetByName(string name);
		IEnumerable<SubGroup> GetByMainGroupId(int mainGroupId);
	}
}