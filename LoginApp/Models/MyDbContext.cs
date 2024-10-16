using Microsoft.EntityFrameworkCore;

namespace LoginApp.Models
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
		{

		}
		public DbSet<User> Users { get; set; }
	}
}
