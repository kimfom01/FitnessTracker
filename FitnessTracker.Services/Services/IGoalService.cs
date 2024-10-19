using FitnessTracker.Domain;

namespace FitnessTracker.CoreLogic.Services;

public interface IGoalService
{
    Task<Goal> CreateNew(int userId, string title, double caloriesTarget, CancellationToken cancellationToken = default);
    Task<IEnumerable<Goal>> GetAllGoals(int userId, CancellationToken cancellationToken = default);
}
