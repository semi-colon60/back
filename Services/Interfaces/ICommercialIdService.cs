using dotnet.DataAccess.Models;

namespace dotnet.Services.Interfaces
{
    public interface ICommercialIdService
    {
        CommercialId GetById(int id);
        IEnumerable<CommercialId> GetAll();
        void Add(CommercialId commercialId);
        void Update(CommercialId commercialId);
        void Delete(int id);

        // Additional get methods
        IEnumerable<CommercialId> GetByName(string name);
        IEnumerable<CommercialId> GetBySurname(string surname);
        IEnumerable<CommercialId> GetByNameAndSurname(string name, string surname);
        IEnumerable<CommercialId> GetByCommercialTitle(string commercialTitle);
        IEnumerable<CommercialId> GetByPhone(string phone);
        IEnumerable<CommercialId> GetByEmail(string email);
        CommercialId GetByUsername(string username);

        // Additional business logic methods
    }
}
