using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Database;

public class FitnessContext : DbContext
{
    public DbSet<ApplicationUser> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=fitness_tracker.db");

        base.OnConfiguring(optionsBuilder);
    }
}
