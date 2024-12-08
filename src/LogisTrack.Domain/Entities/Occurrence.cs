using LogisTrack.Domain.Enums;

namespace LogisTrack.Domain.Entities;

public class Occurrence : Entity
{
    public Occurrence(
        EOccurrenceType occurrenceType,
        string description,
        DateTime occurredAt)
    {
        OccurrenceType = occurrenceType;
        Description = description;
        OccurredAt = occurredAt;
    }

    public EOccurrenceType OccurrenceType { get; private set; }
    public string Description { get; private set; }
    public DateTime OccurredAt { get; private set; }

    protected int OrderId { get; private set; }
    public Order Order { get; private set; } = null!;
}
