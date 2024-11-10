using FitnessTracker.CoreLogic.Exceptions;
using FitnessTracker.DataAccess.Repositories;
using FitnessTracker.Domain.Activities;

namespace FitnessTracker.CoreLogic.Services;

public class ActivitiesService : IActivitiesService
{
    private readonly IGoalRepository _goalRepository;
    private readonly ICyclingRepository _cyclingRepository;

    public ActivitiesService(IGoalRepository goalRepository, ICyclingRepository cyclingRepository)
    {
        _goalRepository = goalRepository;
        _cyclingRepository = cyclingRepository;
    }

    public async Task<Cycling> LogCycling(int userId, double distance, double timeTaken, double heartRate)
    {
        var goalId = await _goalRepository.GetCurrentMonthsGoalId(userId);

        if (goalId is null)
        {
            throw new NotFoundException("You need to set a goal for this month.");
        }

        var cycling = Cycling.Create(goalId.Value, userId, distance, TimeSpan.FromMinutes(timeTaken), heartRate);
        var added = await _cyclingRepository.Add(cycling);
        await _cyclingRepository.SaveChangesAsync();

        return added;
    }
}