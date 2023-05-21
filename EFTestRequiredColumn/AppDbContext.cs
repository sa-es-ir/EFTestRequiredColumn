using Microsoft.EntityFrameworkCore;

namespace EFTestRequiredColumn;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("connection-string");
    }

    public DbSet<Customer> Customers { get; set; }
}
