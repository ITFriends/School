class Person
{

}

using System;
 
namespace HelloApp
{
    class Person
    {

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

using System;
 
namespace HelloApp
{
    class Person
    {
        public string name; // имя
        public int age = 18;     // возраст

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom;
        }
    }
}

class Person
{
    public string name; // имя
    public int age;     // возраст

    public void GetInfo()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person tom = new Person();
        tom.GetInfo();      // Имя: Возраст: 0

        tom.name = "Tom";
        tom.age = 34;
        tom.GetInfo();  // Имя: Tom Возраст: 34
        Console.ReadKey();
    }
}

class Person
{
    public string name;
    public int age;

    public Person() { name = "Неизвестно"; age = 18; }      // 1 конструктор

    public Person(string n) { name = n; age = 18; }         // 2 конструктор

    public Person(string n, int a) { name = n; age = a; }   // 3 конструктор

    public void GetInfo()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}

static void Main(string[] args)
{
    Person tom = new Person();          // вызов 1-ого конструктора без параметров
    Person bob = new Person("Bob");     //вызов 2-ого конструктора с одним параметром
    Person sam = new Person("Sam", 25); // вызов 3-его конструктора с двумя параметрами


    bob.GetInfo();          // Имя: Bob  Возраст: 18
    tom.GetInfo();          // Имя: Неизвестно  Возраст: 18
    sam.GetInfo();          // Имя: Sam  Возраст: 25
}

Person tom = new();            // аналогично new Person();
Person bob = new("Bob");       // аналогично new Person("Bob");
Person sam = new("Sam", 25);   // аналогично new Person("Sam", 25);

class Person
{
    public string name;
    public int age;

    public Person() : this("Неизвестно")
    {
    }
    public Person(string name) : this(name, 18)
    {
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void GetInfo()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}

public Person(string name) : this(name, 18)
{
}

public Person(string name, int age)
{
    this.name = name;
    this.age = age;
}

Person tom = new Person { name = "Tom", age = 31 };
tom.GetInfo();          // Имя: Tom  Возраст: 31