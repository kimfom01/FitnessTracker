using FitnessTracker.Domain.Activities;

namespace FitnessTracker.Domain;

public class Goal : BaseEntity
{
    public int UserId { get; private set; }
    public ApplicationUser? User { get; private set; }
    public string Title { get; private set; }
    public double CaloriesTarget { get; private set; }
    public double Progress { get; private set; }
    public int Month { get; private set; }
    public int Year { get; private set; }

    public IReadOnlyList<Walking> Walkings { get; private set; }
    public IReadOnlyList<Swimming> Swimmings { get; private set; }
    public IReadOnlyList<Cycling> Cyclings { get; private set; }
    public IReadOnlyList<Running> Runnings { get; private set; }
    public IReadOnlyList<WeightLifting> WeightLiftings { get; private set; }

    private Goal(int userId, string title, double caloriesTarget)
    {
        UserId = userId;
        Title = title;
        CaloriesTarget = caloriesTarget;
        Walkings = new List<Walking>();
        Swimmings = new List<Swimming>();
        Cyclings = new List<Cycling>();
        Runnings = new List<Running>();
        Month = DateTime.UtcNow.Month;
        Year = DateTime.UtcNow.Year;
        WeightLiftings = new List<WeightLifting>();
    }

    public static Goal Create(int userId, string title, double caloriesTarget)
    {
        return new Goal(userId, title, caloriesTarget);
    }
}
