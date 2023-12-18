using dotnet.DataAccess.Interfaces;
using dotnet.Services.DTOs;
using dotnet.Services.Interfaces;

namespace dotnet.Services {
	public class ReviewOrderService : IReviewOrderService
	{
		private readonly IOrderRepository _orderRepository;

		private readonly ICommercialIdRepository _commercialIdRepository;

		public ReviewOrderService(IOrderRepository orderRepository, ICommercialIdRepository commercialIdRepository)
		{
			_orderRepository = orderRepository;
			_commercialIdRepository = commercialIdRepository;
		}
		public async Task<IEnumerable<OrderDTO>> GetAllOrdersAsync()
		{
			var orders = await _orderRepository.GetAllAsync();
			var enumerator = orders.GetEnumerator();

			List<OrderDTO> orderDTO = new();

			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				var commercialId = await _commercialIdRepository.GetByIdAsync(current.CommercialId);
				orderDTO.Add(new OrderDTO(current, commercialId));
			}

			return orderDTO;
		}
	}
}