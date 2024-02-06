////////////////////////////////////////////////////////////////////////////////////
// FileName: Wages.cs
// FileType: Visual C# Source file
// Author : Truitt Thuecks
// Description : C# program that creates a message based on user response.
// Course: CSCI-1250-004
// Professor: Gillenwater
////////////////////////////////////////////////////////////////////////////////////
namespace madlibs;

class Program
{
    static void Main(string[] args)
    {
        //Variable declarations
        string name;
        int age;
        string city;
        string country;
        string profession;
        string animal;
        string petName;

        //Prompts user for name, age, favorite city, favorite country,
        //profession, favorite animal, and pets name. Each time the
        //user answers, the response is read in and saved for the message
        // that is printed out after each answer is answered.
        Console.WriteLine("What is your name? ");
        name = Console.ReadLine();
        Console.WriteLine("What is your age? ");
        age = int.Parse(Console.ReadLine());
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

        //Message including all the answers read in above.
        Console.WriteLine("There once was a person named " + name + " who lived in " + city + ". At the age of " + age + ", " + name + " decided to move to " + country + " and become a " + profession + ". Then, " + name + " adopted a " + animal + " named " + petName + ". They both lived happily ever after!");
        Console.ReadLine();
    }
}

