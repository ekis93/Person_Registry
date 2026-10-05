namespace Person_Registry;
using UI;
using Models.Person;

class Program
{
    static void Main(string[] args)
    {
        //ConsoleUi.ConsoleUi uiHandler = new ConsoleUi();
        ConsoleUi ui = new ConsoleUi();
        Company company = new Company("AllTech", "We do tech");
        Address address = new Address("Something Street","12345","SomeCity");
        Person person = new Person
            ("123456-7890",
                "John Doe",
                "J.D@gmail.com",
                address,
                company);
        
        ui.ShowUi(person.Address.AddressName);
    }
    
}