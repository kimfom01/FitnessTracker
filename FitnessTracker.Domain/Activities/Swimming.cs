namespace FitnessTracker.Domain.Activities;

public class Swimming : BaseEntity
{
    public int UserId { get; set; }
    public ApplicationUser? User { get; private set; }
    public int GoalId { get; set; }
    public Goal? Goal { get; private set; }
    public int Laps { get; set; }
    public TimeSpan TimeTaken { get; set; }
    public double HeartRate { get; set; }
    public double Calories { get; set; }
}
