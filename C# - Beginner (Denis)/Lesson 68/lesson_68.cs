public record Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var person = new Person() { Name = "Tom" };
        person.Name = "Bob";
        Console.WriteLine(person.Name); // Bob
    }
}
public record Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var person = new Person() { Name = "Tom" };
        person.Name = "Bob";    // ошибка
        Console.WriteLine(person.Name); // Bob
    }
}
public record Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}

using System;
 
namespace TestNET5ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person() { Name = "Tom" };
            var person2 = new Person() { Name = "Tom" };
            Console.WriteLine(person1.Equals(person2)); // true

            var user1 = new User() { Name = "Tom" };
            var user2 = new User() { Name = "Tom" };
            Console.WriteLine(user1.Equals(user2));     // false
        }
    }

    public record Person
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }

    public class User
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }
}

var person1 = new Person() { Name = "Tom" };
var person2 = new Person() { Name = "Tom" };
Console.WriteLine(person1 == person2);    // true

var user1 = new User() { Name = "Tom" };
var user2 = new User() { Name = "Tom" };
Console.WriteLine(user1 == user2); //	false
Оператор with

var person1 = new Person() { Name = "Tom", Age = 36 };
var person2 = person1 with { Name = "Sam" };
Console.WriteLine($"{person2.Name} - {person2.Age}"); // Sam - 36

public record Person
{
    public string Name { get; init; }
    public int Age { get; init; }
    public Person(string n, int age)
    {
        Name = n; Age = age;
    }
    public void Deconstruct(out string personName, out int personAge) => (personName, personAge) = (Name, Age);
}

var person = new Person("Tom", 36);
Console.WriteLine(person.Name); // Tom

var (userName, userAge) = person;

Console.WriteLine(userAge);     // 36
Console.WriteLine(userName);    // Tom

public record Person(string Name, int Age);

using System;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Tom", 36);
            Console.WriteLine(person.Name); // Tom

            var (userName, userAge) = person;

            Console.WriteLine(userAge);     // 36
            Console.WriteLine(userName);    // Tom
        }
    }
    public record Person(string Name, int Age);
}