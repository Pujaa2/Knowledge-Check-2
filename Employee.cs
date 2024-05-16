// Employee class inheriting from Person
public class Employee : Person
{
    public string Department { get; set; }

    // Override ToString method to print object details including Employee-specific properties
    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}, Address: {Address}, Department: {Department}";
    }
}
