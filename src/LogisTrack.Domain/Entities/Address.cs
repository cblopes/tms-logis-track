using LogisTrack.Domain.Enums;

namespace LogisTrack.Domain.Entities;

public class Address : Entity
{
    public Address(
        string street,
        string number,
        string neighborhood,
        string city,
        EState state,
        string zipCode,
        string? complement = null)
    {
        Street = street;
        Number = number;
        Complement = complement;
        Neighborhood = neighborhood;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    public string Street { get; private set; }
    public string Number { get; private set; }
    public string? Complement { get; private set; }
    public string Neighborhood { get; private set; }
    public string City { get; private set; }
    public EState State { get; private set; }
    public string ZipCode { get; private set; }
}
