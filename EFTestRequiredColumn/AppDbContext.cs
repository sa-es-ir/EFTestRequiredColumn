using Microsoft.EntityFrameworkCore;

namespace EFTestRequiredColumn;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("connection-string");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // to show the issue with these line should be commented and after you can uncomment and run the migration again
        //modelBuilder.Entity<Student>()
        //    .HasKey(x => x.Id);

        //modelBuilder.Entity<Student>()
        //    .HasIndex(x => x.UniqueCode)
        //    .IsUnique();
    }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Student> Students { get; set; }
}
