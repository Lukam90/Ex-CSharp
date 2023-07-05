using Microsoft.EntityFrameworkCore;

using BlazorCourse.Models;

namespace BlazorCourse.Data.Contexts;

public class DeveloperDbContext : DbContext
{
    public DeveloperDbContext(DbContextOptions<DeveloperDbContext> options) : base(options)
    {
    }

    public DbSet<Developer> Developers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Developer>().
            HasData(
                new Developer() { Id = Guid.NewGuid(), Company = "Nintendo", Email = "mario@test.com", UserName = "Mario" },
                new Developer() { Id = Guid.NewGuid(), Company = "Nintendo", Email = "luigi@test.com", UserName = "Luigi" }
            );
    }
}