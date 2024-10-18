using FitnessTracker.Domain.Activities;

namespace FitnessTracker.Domain;

public class Goal : BaseEntity
{
    public int UserId { get; private set; }
    public ApplicationUser? User { get; private set; }
    public double CaloriesTarget { get; private set; }
    public double Progress { get; private set; }

    public ICollection<Walking> Walkings { get; private set; }
    public ICollection<Swimming> Swimmings { get; private set; }

    private Goal(int userId, double caloriesTarget)
    {
        UserId = userId;
        CaloriesTarget = caloriesTarget;
        Walkings = new List<Walking>();
        Swimmings = new List<Swimming>();
    }

    public static Goal Create(int userId, double caloriesTarget)
    {
        return new Goal(userId, caloriesTarget);
    }
}
