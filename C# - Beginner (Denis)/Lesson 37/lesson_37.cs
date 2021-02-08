class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public virtual void Display()
    {
        Console.WriteLine(Name);
    }
}
class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
}

static void Main(string[] args)
{
    Person p1 = new Person("Bill");
    p1.Display(); // вызов метода Display из класса Person

    Employee p2 = new Employee("Tom", "Microsoft");
    p2.Display(); // вызов метода Display из класса Person

    Console.ReadKey();
}

class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company)
        : base(name)
    {
        Company = company;
    }

    public override void Display()
    {
        Console.WriteLine($"{Name} работает в {Company}");
    }
}

static void Main(string[] args)
{
    Person p1 = new Person("Bill");
    p1.Display(); // вызов метода Display из класса Person

    Employee p2 = new Employee("Tom", "Microsoft");
    p2.Display(); // вызов метода Display из класса Employee

    Console.ReadKey();
}

class Credit
{
    public virtual decimal Sum { get; set; }
}
class LongCredit : Credit
{
    private decimal sum;
    public override decimal Sum
    {
        get
        {
            return sum;
        }
        set
        {
            if (value > 1000)
            {
                sum = value;
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        LongCredit credit = new LongCredit { Sum = 6000 };
        credit.Sum = 490;
        Console.WriteLine(credit.Sum);
        Console.ReadKey();
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

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"работает в {Company}");
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

    public override sealed void Display()
    {
        Console.WriteLine($"{Name} работает в {Company}");
    }
}