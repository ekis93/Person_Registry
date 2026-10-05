namespace Person_Registry.Models.Person;

public class Address
{
    public Address(string addressName, string postalCode, string city)
    {
        AddressName = addressName;
        PostalCode = postalCode;
        City = city;
    }

    public string AddressName { get; private set; }
    public string PostalCode { get; private set; }
    public string City { get; private set; }
}