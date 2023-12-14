using System.Formats.Asn1;
using dotnet.DataAccess.Interfaces;
using dotnet.Services.DTOs;
using dotnet.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace dotnet.Services {
    public class AddUserService : IAddUserService
    {   
        private readonly ICommercialIdRepository commercialRepo;

        public AddUserService(ICommercialIdRepository commercialIdRepository)
		{
			commercialRepo = commercialIdRepository;
		}
        public  async Task PushAsync(CommercialId commercialId)
        {
            try
            {
                await commercialRepo.AddAsync(commercialId);
            }
            catch (System.Exception err)
            {
                Console.WriteLine("Error from service"  + err);
                throw;
            }
            
        }
    }
}