using dotnet.DataAccess.Interfaces;
using dotnet.Services.DTOs;
using dotnet.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace dotnet.Services {
	public class CartItemsService : ICartItemsService
	{
		private readonly ICartItemsRepository _cartItemRepository;
		private readonly IMaterialRepository _materialRepository;

		private readonly ISubGroupRepository _subGroupRepository;
		private readonly IMainGroupRepository _mainGroupRepository;
		public CartItemsService(IMaterialRepository materialRepository, ICartItemsRepository cartItemsRepository,
						IMainGroupRepository mainGroupRepository, ISubGroupRepository subGroupRepository)
		{
			_cartItemRepository = cartItemsRepository;
			_materialRepository = materialRepository;
			_mainGroupRepository = mainGroupRepository;
			_subGroupRepository = subGroupRepository;
		}
        public async Task<IEnumerable<CartItems>> GetCartItems(Int64 id)
        {
           
			try
			{
				return await  _cartItemRepository.GetCartItems(id);
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
				var cart_items = await  _cartItemRepository.GetCartItems(id);
				List<CartItemInfosDTO> cartInfos = new List<CartItemInfosDTO>();
				foreach (var cartItem in cart_items)
				{
					var material =await _materialRepository.GetByIdAsync(cartItem.MaterialID);
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


        /*        public async Task<LoginUserDTO?> GetCommercialIdByEmailAsync(string email, string password)
                {
                    var result = await _commercialIdRepository.GetByEmailAsync(email);
                    var loginUserDTO = new LoginUserDTO(result.IsAdmin, result.CommercialID);
                    if(result != null && result.Password == password) {
                        return loginUserDTO;
                    }
                    return null;
                }
        */
    }
}