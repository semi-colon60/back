using dotnet.DataAccess.Interfaces;
using dotnet.Services.DTOs;

namespace dotnet.Services.Interfaces
{
	public class UserListMaterialsService : IUserListMaterialsService
	{
		private readonly IMaterialRepository _materialRepository;
		private readonly IMainGroupRepository _mainGroupRepository;
		private readonly ISubGroupRepository _subGroupRepository;
		private readonly ICartItemRepository _cartItemRepository;

		public UserListMaterialsService(IMaterialRepository materialRepository,
										IMainGroupRepository mainGroupRepository,
										ISubGroupRepository subGroupRepository,
										ICartItemRepository cartItemRepository)
		{
			_materialRepository = materialRepository;
			_mainGroupRepository = mainGroupRepository;
			_subGroupRepository = subGroupRepository;
			_cartItemRepository = cartItemRepository;
		}

		public async Task<CartItem> AddMaterialToCart(CartItem cartItem)
		{
			CartItem cartItemFromDb = await _cartItemRepository.GetCartItem(cartItem.MaterialId, cartItem.CommercialId);

			if (cartItemFromDb == null)
			{
				await _cartItemRepository.AddCartItem(cartItem);
				return cartItem;
			}
			else
			{
				cartItemFromDb.Quantity += cartItem.Quantity;
				await _cartItemRepository.UpdateCartItem(cartItemFromDb);
				return cartItemFromDb;
			}
		}

		public async Task<TotalCartValues> GetTotals(Int64 CommercialId)
		{
			TotalCartValues	_totalCartValues = new();
			IEnumerable<CartItem> cartItems = await _cartItemRepository.GetAllCartByCommercialId(CommercialId);

			foreach (CartItem cartItem in cartItems)
			{
				Material material = await _materialRepository.GetByIdAsync(cartItem.MaterialId);
				double unitPrice = 0.0,
					   unitWeight = 0.0,
					   unitVolume = 0.0;

				if (material != null)
				{
					if (material.UnitPrice.Trim() != "")
						unitPrice = double.Parse(material.UnitPrice);
					if (material.Mass.Trim() != "")
						unitWeight = double.Parse(material.Mass);
					if (material.Volume.Trim() != "")
						unitVolume = double.Parse(material.Volume);
				}

				_totalCartValues.TotalPrice += unitPrice * cartItem.Quantity;
				_totalCartValues.TotalWeight += unitWeight * cartItem.Quantity;
				_totalCartValues.TotalVolume += unitVolume * cartItem.Quantity;
			}
			return _totalCartValues;
		}

		public async Task<IEnumerable<MainGroup>> GetAllMainGroupsAsync()
		{
			return await _mainGroupRepository.GetAllAsync();
		}

		public async Task<IEnumerable<Material>> GetAllMaterialsAsync()
		{
			return await _materialRepository.GetAllAsync();
		}

		public async Task<IEnumerable<Material>> GetMaterialsByMainGroupIdAsync(long id)
		{
			return await _materialRepository.GetByMainGroupIdAsync(id);
		}

		public async Task<IEnumerable<Material>> GetMaterialsBySubGroupIdAsync(long id)
		{
			return await _materialRepository.GetBySubGroupIdAsync(id);
		}

		public async Task<IEnumerable<SubGroup>> GetSubGroupsByMainGroupId(long id)
		{
			return await _subGroupRepository.GetByMainGroupIdAsync(id);
		}
	}
}