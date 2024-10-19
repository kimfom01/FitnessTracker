using FitnessTracker.DataAccess.Repositories;
using FitnessTracker.Domain;

namespace FitnessTracker.CoreLogic.Services;

public class GoalService : IGoalService
{
    private readonly IGoalRepository _goalsRepository;

    public GoalService(IGoalRepository goalsRepository)
    {
        _goalsRepository = goalsRepository;
    }

    public async Task<Goal> CreateNew(int userId, string title, double caloriesTarget, CancellationToken cancellationToken = default)
    {
        var newGoal = Goal.Create(userId, title, caloriesTarget);

        var createdGoal = await _goalsRepository.CreateGoal(newGoal, cancellationToken);
        await _goalsRepository.SaveChangesAsync(cancellationToken);

        return createdGoal;
    }

    public async Task<IEnumerable<Goal>> GetAllGoals(int userId, CancellationToken cancellationToken = default)
    {
        return await _goalsRepository.GetAllGoals(userId, cancellationToken);
    }
}
