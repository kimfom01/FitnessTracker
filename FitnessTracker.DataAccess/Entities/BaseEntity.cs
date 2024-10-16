namespace FitnessTracker.DataAccess.Entities;

public abstract class BaseEntity
{
    public int Id { get; internal set; }
    public DateTime CreatedAtUtc { get; internal set; }
    public DateTime UpdatedAtUtc { get; internal set; }
}
