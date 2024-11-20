using Microsoft.EntityFrameworkCore;
using EFCoreDemo.Models;

public class AppDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EFCoreDemoDb;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasOne(p=> p.Address)
            .WithMany(a=> a.People)
            .HasForeignKey(p=> p.AddressId);
    }
}