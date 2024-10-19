using FitnessTracker.Domain.Activities;

namespace FitnessTracker.Domain;

public class Goal : BaseEntity
{
    public int UserId { get; private set; }
    public ApplicationUser? User { get; private set; }
    public string Title { get; private set; }
    public double CaloriesTarget { get; private set; }
    public double Progress { get; private set; }

    public ICollection<Walking> Walkings { get; private set; }
    public ICollection<Swimming> Swimmings { get; private set; }

    private Goal(int userId, string title, double caloriesTarget)
    {
        UserId = userId;
        Title = title;
        CaloriesTarget = caloriesTarget;
        Walkings = new List<Walking>();
        Swimmings = new List<Swimming>();
    }

    public static Goal Create(int userId, string title, double caloriesTarget)
    {
        return new Goal(userId, title, caloriesTarget);
    }
}
