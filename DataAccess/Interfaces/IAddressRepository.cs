namespace dotnet.DataAccess.Interfaces
{
	public interface IAddressRepository
	{
		Task AddAdressAsync(Address address);
		Task<IEnumerable<Address>> GetAddressesByCommercialId(long id);
		Task<Address?> GetById(long id);
	}
}