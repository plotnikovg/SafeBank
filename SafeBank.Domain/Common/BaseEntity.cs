namespace SafeBank.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }

	private List<BaseEvent> _domainEvents = new();
}