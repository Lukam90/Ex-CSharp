using Microsoft.EntityFrameworkCore;

using MudBlazorApp.Server.Models;

namespace MudBlazorApp.Server.Data.Context;

public class SupplierDbContext : DbContext
{
    public SupplierDbContext(DbContextOptions<SupplierDbContext> options) : base(options) {}

    public DbSet<Supplier> Suppliers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Supplier>()
            .HasData(
                new Supplier() { Id = Guid.NewGuid(), Name = "ABC", Company = "GetTech Limited", Email = "gt@limited.com" },
                new Supplier() { Id = Guid.NewGuid(), Name = "IJK", Company = "Cleaning Limited", Email = "clean@limited.com" }
            );
    }
}
