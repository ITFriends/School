int i = 5;
Console.WriteLine(i.ToString()); // выведет число 5

double d = 3.5;
Console.WriteLine(d.ToString()); // выведет число 3,5

using System;
 
namespace FirstApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person { Name = "Tom" };
            Console.WriteLine(person.ToString()); // выведет название класса Person

            Clock clock = new Clock { Hours = 15, Minutes = 34, Seconds = 53 };
            Console.WriteLine(clock.ToString()); // выведет 15:34:53

            Console.Read();
        }
    }
    class Clock
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}

class Person
{
    public string Name { get; set; }
    public override string ToString()
    {
        if (String.IsNullOrEmpty(Name))
            return base.ToString();
        return Name;
    }
}

private static void Main(string[] args)
{
    Person person = new Person { Name = "Tom" };
    Console.WriteLine(person);

    Clock clock = new Clock { Hours = 15, Minutes = 34, Seconds = 53 };
    Console.WriteLine(clock); // выведет 15:34:53

    Console.Read();
}

class Person
{
    public string Name { get; set; }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}

Person person = new Person { Name = "Tom" };
Console.WriteLine(person.GetType());    // Person

object person = new Person { Name = "Tom" };
if (person.GetType() == typeof(Person))
    Console.WriteLine("Это реально класс Person");

class Person
{
    public string Name { get; set; }
    public override bool Equals(object obj)
    {
        if (obj.GetType() != this.GetType()) return false;

        Person person = (Person)obj;
        return (this.Name == person.Name);
    }
}

Person person1 = new Person { Name = "Tom" };
Person person2 = new Person { Name = "Bob" };
Person person3 = new Person { Name = "Tom" };
bool p1Ep2 = person1.Equals(person2);   // false
bool p1Ep3 = person1.Equals(person3);   // true