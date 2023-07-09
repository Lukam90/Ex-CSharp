using Microsoft.EntityFrameworkCore;

using MvcApp.Models;

namespace MvcApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    public DbSet<Category> Categories { get; set; }
}