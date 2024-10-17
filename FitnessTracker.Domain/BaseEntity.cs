namespace FitnessTracker.Domain;

public abstract class BaseEntity
{
    public int Id { get; internal set; }
    public DateTime CreatedAtUtc { get; internal set; }
    public DateTime UpdatedAtUtc { get; internal set; }

    public void SetCreatedAtUtc(DateTime createdAtUtc)
    {
        CreatedAtUtc = createdAtUtc;
    }

    public void SetUpdatedAtUtc(DateTime updatedAtUtc)
    {
        UpdatedAtUtc = updatedAtUtc;
    }
}
