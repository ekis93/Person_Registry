namespace Person_Registry.Models.Person;

public class Person
{
    public Person(
        string idNumber, string name, string email, 
        Address address, Company company)
    {
        IdNumber = idNumber;
        Name = name;
        Email = email;
        Address = address;
        Company = company;
    }

    public string IdNumber { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public Address Address { get; private set; }
    public Company Company { get; private set; }
}