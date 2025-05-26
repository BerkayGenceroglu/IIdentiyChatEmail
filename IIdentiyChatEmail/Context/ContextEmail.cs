using IIdentiyChatEmail.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IIdentiyChatEmail.Context
{
	public class ContextEmail: IdentityDbContext<AppUser>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-SK0HNP2\\SQLEXPRESS;initial Catalog=EmailChatProject; integrated security=true; trust server certificate=true");
		}

		public DbSet<Message> messages { get; set; }

	}
}
