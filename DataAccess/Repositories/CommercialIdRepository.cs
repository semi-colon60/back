using dotnet.DataAccess.DbContexts;
using dotnet.DataAccess.Interfaces;
using dotnet.DataAccess.Models;

namespace dotnet.DataAccess.Repositories
{
	public class CommercialIdRepository : ICommercialIdRepository
	{
		public readonly ApplicationContext Context;
		public CommercialIdRepository(ApplicationContext context)
		{
			Context = context;
		}

        public Task AddAsync(CommercialId commercialId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommercialId>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommercialId>> GetByCommercialTitleAsync(string commercialTitle)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommercialId>> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<CommercialId> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommercialId>> GetByNameAndSurnameAsync(string name, string surname)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommercialId>> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommercialId>> GetByPhoneAsync(string phone)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommercialId>> GetBySurnameAsync(string surname)
        {
            throw new NotImplementedException();
        }

        public Task<CommercialId> GetByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CommercialId commercialId)
        {
            throw new NotImplementedException();
        }
    }
}