using System;
using System.Collections.Generic;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Department { get; set; }

    // Override ToString method to print object details
    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}, Address: {Address}, Department: {Department}";
    }
}