namespace SalesDemo.Domain.Core;

public abstract class Entity
{
    public Guid Id { get; private set; }
    public DateTime Inserted { get; private set; }
    public DateTime? Updated { get; private set; }
}