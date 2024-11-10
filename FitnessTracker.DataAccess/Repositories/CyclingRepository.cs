using FitnessTracker.Domain.Activities;

namespace FitnessTracker.DataAccess.Repositories;

public class CyclingRepository : ICyclingRepository
{
    private readonly FitnessContext _context;

    public CyclingRepository(FitnessContext context)
    {
        _context = context;
    }

    public async Task<Cycling> Add(Cycling cycling)
    {
        var entry = await _context.Cyclings.AddAsync(cycling);
        return entry.Entity;
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}