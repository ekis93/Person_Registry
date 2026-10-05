namespace Person_Registry.Models.Person;

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