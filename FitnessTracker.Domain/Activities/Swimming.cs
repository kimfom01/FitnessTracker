﻿namespace FitnessTracker.Domain.Activities;

public class Swimming : BaseEntity
{
    public int UserId { get; private set; }
    public ApplicationUser? User { get; private set; }
    public int GoalId { get; private set; }
    public Goal? Goal { get; private set; }
    public int Laps { get; private set; }
    public TimeSpan TimeTaken { get; private set; }
    public double HeartRate { get; private set; }
    public double Calories { get; private set; }
}
