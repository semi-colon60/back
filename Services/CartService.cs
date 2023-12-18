using dotnet.DataAccess.Interfaces;
using dotnet.Services.DTOs;
using dotnet.Services.Interfaces;

namespace dotnet.Services {
	public class CartService : ICartService
	{
		private readonly ICartItemRepository _cartItemRepository;
		private readonly IMaterialRepository _materialRepository;
		private readonly ISubGroupRepository _subGroupRepository;
		private readonly IMainGroupRepository _mainGroupRepository;
		
		public CartService(IMaterialRepository materialRepository, ICartItemRepository cartItemsRepository,
						IMainGroupRepository mainGroupRepository, ISubGroupRepository subGroupRepository)
		{
			_cartItemRepository = cartItemsRepository;
			_materialRepository = materialRepository;
			_mainGroupRepository = mainGroupRepository;
			_subGroupRepository = subGroupRepository;
		}

        public async Task<IEnumerable<CartItem>> GetCartItems(Int64 id)
        {
           
			try
			{
				return await  _cartItemRepository.GetAllCartByCommercialId(id);
			}
			catch (System.Exception)
			{
				Console.WriteLine("Service error\n");
				throw;
			}
		}

        public async Task<IEnumerable<CartItemInfosDTO>> GetCartItemInfos(Int64 id)
		{
			try
			{
				var cart_items = await  _cartItemRepository.GetAllCartByCommercialId(id);
				List<CartItemInfosDTO> cartInfos = new List<CartItemInfosDTO>();
				foreach (var cartItem in cart_items)
				{
					var material =await _materialRepository.GetByIdAsync(cartItem.MaterialId);
					var mg = await _mainGroupRepository.GetByIdAsync(material.MainGroupId);
					var sg = await _subGroupRepository.GetByIdAsync(material.SubGroupId);

					var cartItemInfosDTO = new CartItemInfosDTO(cartItem.CartItemId, material.MainGroupId, material.SubGroupId, material.MaterialCode,
																	material.Description, material.Unit, cartItem.Quantity, material.UnitPrice,
																	material.Mass, material.Volume, material.Count, mg.Name, sg.Name);
					cartInfos.Add(cartItemInfosDTO);
				}
				return cartInfos;
			}
			catch (System.Exception)
			{
				Console.WriteLine("Service Error\n\n");
				throw;
			}
		}
    }
}