namespace LogisTrack.Domain.Entities;

public class Client : Entity
{
    public Client(
        string firstName,
        string lastName,
        string document,
        string phone,
        string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Document = document;
        Phone = phone;
        Email = email;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Document { get; private set; }
    public string Phone { get; private set; }
    public string Email { get; private set; }

    protected int AddressId { get; private set; }
    public Address Address { get; private set; } = null!;
    
    public void AssignAddress(Address address)
    {
        AddressId = address.Id;
        Address = address;
    }
}
