namespace SafeBank.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }

    private List<BaseEvent> _domainEvents = new();

    public void AddDomainEvent(BaseEvent event)
    {
        _domainEvents.Add(event);
    }
    public void RemoveDomainEvent(BaseEvent event)
    {
        _domainEvents.Remove(event);
    }
    public void ClearDomainEvent(BaseEvent event)
    {
        _domainEvents.Clear();
    }
}