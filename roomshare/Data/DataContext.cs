using Microsoft.EntityFrameworkCore;
using roomshare.Models;

namespace roomshare.Data
{
	public partial class DataContext : DbContext
	{

		public DataContext(DbContextOptions<DataContext> options)
		: base(options)
		{
		}

		public DataContext()
		{
		}

		public DbSet<House> Houses { get; set; }
		public DbSet<Reserve> Reserves { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=sqlite.db");
		}
		public void ConfigureServices(IServiceCollection services, WebApplicationBuilder builder)
		{
			services.AddDbContext<DataContext>(options =>
				options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
			);
		}
	}
}
