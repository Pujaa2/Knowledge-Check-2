class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many persons do you want to add? ");
        var numberOfPersons = int.Parse(Console.ReadLine());

        var personList = new List<Person>();
        for (int i = 0; i < numberOfPersons; i++)
        {
            var person = new Person();

            Console.WriteLine($"Enter details for Person {i + 1}:");
            Console.Write("ID: ");
            person.Id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            person.Name = Console.ReadLine();

            Console.Write("Age: ");
            person.Age = int.Parse(Console.ReadLine());

            Console.Write("Address: ");
            person.Address = Console.ReadLine();

            Console.Write("Department: ");
            person.Department = Console.ReadLine();

            personList.Add(person);
        }

        Console.WriteLine("\nList of Persons added:");
        foreach (var person in personList)
        {
            Console.WriteLine(person);
        }
    }
}