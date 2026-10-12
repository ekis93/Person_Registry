using Person_Registry.Models.Person;

namespace Person_Registry.Data;

public class DataStorage
{
    public List<Person> GetPeople()
    {
        List<Person> people = new List<Person>()
        {
            new Person(4821, "Sara Lindqvist", "sara.lindqvist@mail.se",
                new Address("Storgatan 12", "815 30", "Tierp"),
                new Company("Lindqvist Bygg AB", "Vi bygger för framtiden")),

            new Person(1307, "Erik Holm", "erik.holm@mail.se",
                new Address("Kungsgatan 45", "753 21", "Uppsala"),
                new Company("Holm IT-konsult", "Teknik som fungerar")),

            new Person(9054, "Maja Ek", "maja.ek@mail.se",
                new Address("Björkvägen 3", "802 50", "Gävle"),
                new Company("Ekdesign", "Form med funktion")),

            new Person(2716, "Oskar Berg", "oskar.berg@mail.se",
                new Address("Sjövägen 8", "722 14", "Västerås"),
                new Company("Bergs Transport", "Alltid i tid")),

            new Person(6643, "Linnea Nyström", "linnea.nystrom@mail.se",
                new Address("Ringvägen 27", "118 60", "Stockholm"),
                new Company("Nyström Ekonomi", "Koll på dina siffror")),

            new Person(1189, "Adam Sjöberg", "adam.sjoberg@mail.se",
                new Address("Hamngatan 5", "411 14", "Göteborg"),
                new Company("Sjöberg Marin", "Trygghet till sjöss")),

            new Person(7390, "Elsa Forsberg", "elsa.forsberg@mail.se",
                new Address("Ängsvägen 19", "903 30", "Umeå"),
                new Company("Forsbergs Bageri", "Nybakat varje morgon")),

            new Person(3562, "Hugo Wallin", "hugo.wallin@mail.se",
                new Address("Parkgatan 2", "582 22", "Linköping"),
                new Company("Wallin Media", "Vi berättar din historia")),

            new Person(8125, "Ida Karlsson", "ida.karlsson@mail.se",
                new Address("Skolgatan 31", "211 34", "Malmö"),
                new Company("Karlsson Trädgård", "Grönare liv")),

            new Person(5048, "Viktor Ahlgren", "viktor.ahlgren@mail.se",
                new Address("Granvägen 14", "702 11", "Örebro"),
                new Company("Ahlgren Säkerhet", "Vi vaktar det viktiga"))
        };
        return people;
    }
}