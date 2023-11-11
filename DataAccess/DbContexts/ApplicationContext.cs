using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess.DbContexts {

	public class ApplicationContext : DbContext {
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}
    }
}