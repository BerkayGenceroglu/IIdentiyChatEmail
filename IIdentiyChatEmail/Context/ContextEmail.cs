using IIdentiyChatEmail.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IIdentiyChatEmail.Context
{
	public class ContextEmail: IdentityDbContext<AppUser>
	{
		private readonly string _connectionString;

		public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
		{
		}

		public DbSet<Message> messages { get; set; }

	}
}
