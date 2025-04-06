namespace SalesDemo.Domain.Core;

public abstract class Entity
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateTime Inserted { get; private set; } = DateTime.UtcNow;
    public DateTime? Updated { get; private set; }
}