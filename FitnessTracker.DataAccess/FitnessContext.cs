using FitnessTracker.Domain;
using FitnessTracker.Domain.Activities;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.DataAccess;

public class FitnessContext : DbContext
{
    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<Goal> Goals { get; set; }
    public DbSet<Swimming> Swimmings { get; set; }
    public DbSet<Walking> Walkings { get; set; }
    public DbSet<Cycling> Cyclings { get; set; }
    public DbSet<Running> Runnings { get; set; }
    public DbSet<WeightLifting> WeightLiftings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=fitness_tracker.db");

        base.OnConfiguring(optionsBuilder);
    }

    public override int SaveChanges()
    {
        var entries = ChangeTracker.Entries<BaseEntity>();

        var currentTime = DateTime.UtcNow;

        foreach (var entry in entries)
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.SetCreatedAtUtc(currentTime);
                    break;
                case EntityState.Modified:
                    entry.Entity.SetUpdatedAtUtc(currentTime);
                    break;
            }
        }

        return base.SaveChanges();
    }
}
