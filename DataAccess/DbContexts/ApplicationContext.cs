using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.DbContexts {

	public class ApplicationContext : DbContext {
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

		// DbSet is used to access the database tables.
		// These are just for testing purposes.
		public DbSet<CommercialId> CommercialIds { get; set; }
		public DbSet<Material> Materials { get; set; }
		public DbSet<MainGroup> MainGroups { get; set; }
		public DbSet<SubGroup> SubGroups { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
    }
}