namespace dotnet.Services.DTOs
{
    public class LoginUserDTO
    { 
        public Int64 _commercialId { get; set; }
        public Boolean _isadmin { get; set; }

        public LoginUserDTO(Boolean isadmin, Int64 commercialId)
		{
			_isadmin = isadmin;
			_commercialId = commercialId;
		}
    }
}
