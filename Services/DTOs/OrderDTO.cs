namespace dotnet.Services.DTOs
{
	public class OrderDTO
	{
		public Order? _order { get; set; } = null;
		public CommercialId? _commercialId { get; set; } = null;

		public OrderDTO(Order order, CommercialId commercialId)
		{
			_order = order;
			_commercialId = commercialId;
		}
	}
}