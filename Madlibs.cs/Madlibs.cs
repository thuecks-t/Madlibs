namespace Madlibs.cs;

class Program
{
    static void Main(string[] args)
    {


        string name;
        int age;
        string city;
        string country;
        string profession;
        string animal;
        string petName;

        Console.WriteLine("What is your name? ");
        name = Console.ReadLine();
        Console.WriteLine("What is your age? ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is your favorite city? ");
        city = Console.ReadLine();
        Console.WriteLine("What is your favorite country? ");
        country = Console.ReadLine();
        Console.WriteLine("What is your profession? ");
        profession = Console.ReadLine();
        Console.WriteLine("What is your favorite animal? ");
        animal = Console.ReadLine();
        Console.WriteLine("What is your pet's name? ");
        petName = Console.ReadLine();

        Console.WriteLine("There once was a person named " + name + " who lived in " + city + " . At the age of " + age + " , " + name + " decided to move to " + country + " and become a " + profession + " . Then, " + name + " adopted a(n) " + animal + " named " + petName + " . They both lived happily ever after! ");


        
    }
}

