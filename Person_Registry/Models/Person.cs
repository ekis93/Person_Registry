using System.Reflection;
using System.Text.RegularExpressions;
namespace Person_Registry.Models;
public class Person
{
    public Person(
        int idNumber, string name, string email, 
        Address address, Company company)
    {
        IdNumber = idNumber;
        Name = name;
        Email = email;
        Address = address;
        Company = company;
    }
    public int IdNumber { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public Address Address { get; private set; }
    public Company Company { get; private set; }
    public List<string> GetPersonProperties()
    {
        List<string> propertyList = [];
        PropertyInfo[] personProperties = typeof(Person).GetProperties();
        PropertyInfo[] addressProperties = typeof(Address).GetProperties();
        PropertyInfo[] companyProperties = typeof(Company).GetProperties();
        string splitName;
        foreach (var p in personProperties)
        {
            if (p.PropertyType == typeof(int) || p.PropertyType == typeof(string))
            {
                splitName = FormatPropertyName(p);
                propertyList.Add($"[{splitName}]: {p.GetValue(this)}");
            }
        }
        foreach (var a in addressProperties)
        {
            splitName = FormatPropertyName(a);
            propertyList.Add($"[{splitName}]: {a.GetValue(Address)}");
        }
        foreach (var c in companyProperties)
        {
            splitName = FormatPropertyName(c);
            propertyList.Add($"[{splitName}]: {c.GetValue(Company)}");
        }
        return propertyList;
    }
    private string FormatPropertyName(PropertyInfo property)
    {
        return Regex.Replace(property.Name, "([A-Z])", " $1",
            RegexOptions.Compiled).Trim();
    }
}
public class Company
{
    public Company(string companyName, string companySlogan)
    {
        CompanyName = companyName;
        CompanySlogan = companySlogan;
    }
    public string CompanyName { get; private set; }
    public string CompanySlogan { get; private set; }
}
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