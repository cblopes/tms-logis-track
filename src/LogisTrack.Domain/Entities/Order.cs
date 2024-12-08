using LogisTrack.Domain.Enums;

namespace LogisTrack.Domain.Entities;

public class Order : Entity
{
    private IList<Occurrence> _ocurrences;

    public Order(Address destinationAddress)
    {
        Status = EOrderStatus.Pending;
        CreatedAt = DateTime.Now;
        _ocurrences = new List<Occurrence>();
        DestinationAddress = destinationAddress;
        DestinationAddressId = destinationAddress.Id;
    }

    public EOrderStatus Status { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }
    public IReadOnlyCollection<Occurrence> Occurrences { get { return _ocurrences.ToArray(); } }

    protected int DestinationAddressId { get; private set; }
    public Address DestinationAddress { get; private set; } = null!;

    public void AddOccurence(Occurrence occurrence)
    {
        _ocurrences.Add(occurrence);
        UpdatedAt = DateTime.Now;
    }
}
