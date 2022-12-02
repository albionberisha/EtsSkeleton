using Ets.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ets.Data
{
    public class EtsDbContext : DbContext
    {
        public EtsDbContext(DbContextOptions<EtsDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
