using Microsoft.EntityFrameworkCore;
using FreeMarket.API.Models.Domain;

namespace FreeMarket.API.Data
{
    public class FreeMarketDBContext : DbContext
    {
        public FreeMarketDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}