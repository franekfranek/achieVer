using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace API.Models
{
    public class AppUser : IdentityUser
    {
		public DateTime DateOfBirth { get; set; }
		public string KnownAs { get; set; }
		public DateTime Created { get; set; }
		public DateTime LastActive { get; set; }
        public string IpAdress { get; set; }
		public string City { get; set; }

        public virtual ICollection<TaskTodo> TasksTodo { get; set; }
        
    }
}