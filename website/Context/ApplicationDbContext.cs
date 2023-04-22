using Microsoft.EntityFrameworkCore;
using website.Models;

namespace website.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
    }
}