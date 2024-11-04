using FitnessTracker.Domain;

namespace FitnessTracker.DataAccess.Repositories;

public interface IGoalRepository
{
    bool CheckIfMonthGoalExist(int userId);
    Task<Goal> CreateGoal(Goal goal, CancellationToken cancellationToken = default);
    Task<IEnumerable<Goal>> GetAllGoals(int userId, CancellationToken cancellationToken = default);
    Task<Goal?> GetGoalById(int id, int userId, CancellationToken cancellationToken = default);

    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
