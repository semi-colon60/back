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


	}
}