using FitnessTracker.Domain.Activities;

namespace FitnessTracker.DataAccess.Repositories;

public interface ICyclingRepository
{
    public Task<Cycling> Add(Cycling cycling);

    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}