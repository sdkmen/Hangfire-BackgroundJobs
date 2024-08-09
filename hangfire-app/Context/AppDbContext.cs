using Microsoft.EntityFrameworkCore;

namespace hangfire_app.Context
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
