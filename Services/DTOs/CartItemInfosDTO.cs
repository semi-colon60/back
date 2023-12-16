namespace dotnet.Services.DTOs
{
	public class CartItemInfosDTO
	{
		//public Order? _order { get; set; } = null;
		public Int64 ?_MainGroupId { get; set; }

		public Int64 ?id { get; set; }
		public Int64 ?_SubGroupId { get; set; }

		public string ?_MaterialCode { get; set; } = string.Empty;

		public string ?_Description { get; set; } = string.Empty;

		public UnitType	?_Unit {get; set; } = UnitType.Count;

		public Int64 _Quantity { get; set; }

		public Int64 ?_Result { get; set; }

		//public CommercialId? _commercialId { get; set; } = null;

		public string	?_UnitPrice { get; set; } = string.Empty;

		public string	?_Mass { get; set; } = string.Empty;

		public string	?_Volume { get; set; } = string.Empty;

		public int	?_Count { get; set; } = 0;

        public string ?_MainGroupName { get; set; } = string.Empty;

        public string ?_SubGroupName { get; set; } = string.Empty;

		public CartItemInfosDTO(Int64 ?CartItemId, Int64? MainGroupId,Int64? SubGroupId, string ?MaterialCode, string ?Description, UnitType ?Unit,
			Int64 Quantity, string	?UnitPrice, string	?Mass, string	?Volume, int ?Count, string ?MainGroupName, string ?SubGroupName)
		{
			id = CartItemId;
			_MainGroupId = MainGroupId;
			_SubGroupId = SubGroupId;
			_MaterialCode = MaterialCode;
			_Description = Description;
			_Unit = Unit;
			_Quantity = Quantity;
			_UnitPrice = UnitPrice;
			_Mass = Mass;
			_Volume = Volume;
			_Count = Count;
			_MainGroupName = MainGroupName;
			_SubGroupName = SubGroupName;
			_Result = Quantity * int.Parse(UnitPrice);
		}
	}
}