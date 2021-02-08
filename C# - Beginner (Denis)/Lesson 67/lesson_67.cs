public class Person
{
    public string Name { get; init; }
    public int Age { get; set; }
}

using System;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "John Smith"; // Ошибка
            Console.WriteLine(person.Name);
        }
    }

    public class Person
    {
        public string Name { get; init; }
        public int Age { get; set; }
    }
}

var person = new Person();

person.Name = "John Smith"; // Ошибка

using System;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Name = "Tom" };
            Console.WriteLine(person.Name); // Tom
        }
    }

    public class Person
    {
        public string Name { get; init; }
    }
}

using System;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Bob");
            Console.WriteLine(person.Name); // Bob
        }
    }

    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; init; }
        public int Age { get; set; }
    }
}

using System;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Name = "Sam" };
            Console.WriteLine(person.Name);     // Sam
            Console.WriteLine(person.Email);    // Sam@gmail.com
        }
    }

    public class Person
    {
        readonly string name;
        public string Name
        {
            get { return name; }
            init
            {
                name = value;
                Email = $"{value}@gmail.com";
            }
        }
        public string Email { get; init; }
    }
}

public class Person
{
    public Person(string n)
    {
        Name = n;
    }
    public string Name { get; }
}

var person = new Person() { Name = "Sam" }; // ! Ошибка