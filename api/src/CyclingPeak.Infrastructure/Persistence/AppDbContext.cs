using Microsoft.EntityFrameworkCore;
using CyclingPeak.Domain.Entities;

namespace CyclingPeak.Infrastructure.Persistence;

/// <summary>Placeholder — fully configured in Issue #2.</summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
}
