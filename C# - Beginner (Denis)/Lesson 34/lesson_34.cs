class Person
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public void Display()
    {
        Console.WriteLine(Name);
    }
}

class Employee : Person
{

}

static void Main(string[] args)
{
    Person p = new Person { Name = "Tom" };
    p.Display();
    p = new Employee { Name = "Sam" };
    p.Display();
    Console.Read();
}

sealed class Admin
{
}

class Employee : Person
{
    public void Display()
    {
        Console.WriteLine(_name);
    }
}

class Employee : Person
{
    public void Display()
    {
        Console.WriteLine(Name);
    }
}

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine(Name);
    }
}

class Employee : Person
{
    public string Company { get; set; }

    public Employee(string name, string company)
        : base(name)
    {
        Company = company;
    }
}

static void Main(string[] args)
{
    Person p = new Person("Bill");
    p.Display();
    Employee emp = new Employee("Tom", "Microsoft");
    emp.Display();
    Console.Read();
}

class Employee : Person
{
    public string Company { get; set; }
}

public Employee(string name, string company)
{
    Name = name;
    Company = company;
}

public Employee(string name, string company)
        : base(name)
{
    Company = company;
}

class Person
{
    // остальной код класса
    // конструктор по умолчанию
    public Person()
    {
        FirstName = "Tom";
        Console.WriteLine("Вызов конструктора без параметров");
    }
}

public Employee(string company)
{
    Company = company;
}

public Employee(string company)
    :base()
{
    Company = company;
}

class Person
{
    string name;
    int age;

    public Person(string name)
    {
        this.name = name;
        Console.WriteLine("Person(string name)");
    }
    public Person(string name, int age) : this(name)
    {
        this.age = age;
        Console.WriteLine("Person(string name, int age)");
    }
}
class Employee : Person
{
    string company;

    public Employee(string name, int age, string company) : base(name, age)
    {
        this.company = company;
        Console.WriteLine("Employee(string name, int age, string company)");
    }
}

Employee tom = new Employee("Tom", 22, "Microsoft");