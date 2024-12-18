﻿using FitnessTracker.Domain;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.DataAccess.Repositories;

public class GoalRepository : IGoalRepository
{
    private readonly FitnessContext _fitnessContext;

    public GoalRepository(FitnessContext fitnessContext)
    {
        _fitnessContext = fitnessContext;
    }

    public bool CheckIfMonthGoalExist(int userId)
    {
        return _fitnessContext.Goals
            .Where(goal => goal.UserId == userId)
            .Where(goal => goal.Year == DateTime.UtcNow.Year)
            .Where(goal => goal.Month == DateTime.UtcNow.Month)
            .Any();
    }

    public async Task<Goal> CreateGoal(Goal goal, CancellationToken cancellationToken)
    {
        var entry = await _fitnessContext.Goals.AddAsync(goal, cancellationToken);
        return entry.Entity;
    }

    public async Task<IEnumerable<Goal>> GetAllGoals(int userId, CancellationToken cancellationToken)
    {
        return await _fitnessContext.Goals
            .Where(goal => goal.UserId == userId)
            .OrderByDescending(goal => goal.CreatedAtUtc)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<int?> GetCurrentMonthsGoalId(int userId, CancellationToken cancellationToken = default)
    {
        var currentDate = DateTime.UtcNow;
        
        var currentMonthsGoal = await _fitnessContext.Goals
            .Where(goal => goal.UserId == userId)
            .Where(goal => goal.Month == currentDate.Month)
            .Where(goal => goal.Year == currentDate.Year)
            .FirstOrDefaultAsync(cancellationToken);
        
        return currentMonthsGoal?.Id;
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await _fitnessContext.SaveChangesAsync(cancellationToken);
    }
}
