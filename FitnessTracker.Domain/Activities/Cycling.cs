namespace FitnessTracker.Domain.Activities;

public class Cycling : BaseEntity
{
    public int UserId { get; private set; }
    public ApplicationUser? User { get; private set; }
    public int GoalId { get; private set; }
    public Goal? Goal { get; private set; }
    public double Distance { get; private set; }
    public TimeSpan TimeTaken { get; private set; }
    public double HeartRate { get; private set; }
    public double Calories { get; private set; }

    private Cycling(int goalId, int userId, double distance, TimeSpan timeTaken, double heartRate)
    {
        GoalId = goalId;
        UserId = userId;
        Distance = distance;
        TimeTaken = timeTaken;
        HeartRate = heartRate;
        Calories = CalculateCalories(distance, timeTaken, heartRate);
    }

    private double CalculateCalories(double distance, TimeSpan timeTaken, double heartRate)
    {
        return distance * heartRate / timeTaken.TotalSeconds;
    }

    public static Cycling Create(int goalId, int userId, double distance, TimeSpan timeTaken, double heartRate)
    {
        return new Cycling(goalId, userId, distance, timeTaken, heartRate);
    }
}