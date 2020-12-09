using System;

namespace API.DTOs
{
    public class UserToReturnDto
    {
        public int Id { get; set; }
		public string UserName { get; set; }	
		public string Gender { get; set; }
		public string KnownAs { get; set; }
		public DateTime Created { get; set; }
		public DateTime LastActive { get; set; }
		public string City { get; set; }
        public string IpAdress { get; set; }
        public string Token { get; set; }

    }
}