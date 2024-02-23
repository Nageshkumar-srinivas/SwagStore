using Microsoft.EntityFrameworkCore;
using SwagStore.Models;

namespace SwagStore.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
            
        }

        public DbSet<Register> Register { get; set; }
    }
}
