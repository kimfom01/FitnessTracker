using FitnessTracker.Domain.Activities;

namespace FitnessTracker.CoreLogic.Services;

public interface IActivitiesService
{
    Task<Cycling> LogCycling(int userId, double distance, double timeTaken, double heartRate);
}