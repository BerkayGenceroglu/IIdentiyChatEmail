using Microsoft.AspNetCore.Identity;

namespace IIdentiyChatEmail.Entities
{
	public class AppUser : IdentityUser
	{
		public string? ProfileImageURL { get; set; }
		public string? Name { get; set; }
		public string? Surname { get; set; }
	}
}
