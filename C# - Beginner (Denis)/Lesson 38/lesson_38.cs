class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void Display()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}

class Employee : Person
{
    public string Company { get; set; }
    public Employee(string firstName, string lastName, string company)
            : base(firstName, lastName)
    {
        Company = company;
    }
    public new void Display()
    {
        Console.WriteLine($"{FirstName} {LastName} работает в {Company}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person bob = new Person("Bob", "Robertson");
        bob.Display();      // Bob Robertson

        Employee tom = new Employee("Tom", "Smith", "Microsoft");
        tom.Display();      // Tom Smith работает в Microsoft

        Console.ReadKey();
    }
}

class Person
{
    protected string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
class Employee : Person
{
    public new string Name
    {
        get { return "Employee " + base.Name; }
        set { name = value; }
    }
}

class ExampleBase
{
    public readonly int x = 10;
    public const int G = 5;
}
class ExampleDerived : ExampleBase
{
    public new readonly int x = 20;
    public new const int G = 15;
}