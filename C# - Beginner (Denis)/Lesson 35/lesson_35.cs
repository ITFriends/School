class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void Display()
    {
        Console.WriteLine($"Person {Name}");
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

class Client : Person
{
    public string Bank { get; set; }
    public Client(string name, string bank) : base(name)
    {
        Bank = bank;
    }
}

static void Main(string[] args)
{
    Employee employee = new Employee("Tom", "Microsoft");
    Person person = employee;   // преобразование от Employee к Person

    Console.WriteLine(person.Name);
    Console.ReadKey();
}

Person person2 = new Client("Bob", "ContosoBank");   // преобразование от Client к Person

object person1 = new Employee("Tom", "Microsoft");  // от Employee к object
object person2 = new Client("Bob", "ContosoBank");  // от Client к object
object person3 = new Person("Sam");                 // от Person к object

Employee employee = new Employee("Tom", "Microsoft");
Person person = employee;   // преобразование от Employee к Person

Employee employee = new Employee("Tom", "Microsoft");
Person person = employee;   // преобразование от Employee к Person

//Employee employee2 = person;    // так нельзя, нужно явное преобразование
Employee employee2 = (Employee)person;  // преобразование от Person к Employee

// Объект Employee также представляет тип object
object obj = new Employee("Bill", "Microsoft");

// чтобы обратиться к возможностям типа Employee, приводим объект к типу Employee
Employee emp = (Employee)obj;

// объект Client также представляет тип Person
Person person = new Client("Sam", "ContosoBank");
// преобразование от типа Person к Client
Client client = (Client)person;

// Объект Employee также представляет тип object
object obj = new Employee("Bill", "Microsoft");

// преобразование к типу Person для вызова метода Display
((Person)obj).Display();
// либо так
// ((Employee)obj).Display();

// преобразование к типу Employee, чтобы получить свойство Company
string comp = ((Employee)obj).Company;

// Объект Employee также представляет тип object
object obj = new Employee("Bill", "Microsoft");

// преобразование к типу Client, чтобы получить свойство Bank
string bank = ((Client)obj).Bank;

Employee emp = new Person("Tom");   // ! Ошибка

Person person = new Person("Bob");
Employee emp2 = (Employee)person;  // ! Ошибка

Person person = new Person("Tom");
Employee emp = person as Employee;
if (emp == null)
{
    Console.WriteLine("Преобразование прошло неудачно");
}
else
{
    Console.WriteLine(emp.Company);
}

Person person = new Person("Tom");
try
{
    Employee emp = (Employee)person;
    Console.WriteLine(emp.Company);
}
catch (InvalidCastException ex)
{
    Console.WriteLine(ex.Message);
}

Person person = new Person("Tom");
if (person is Employee)
{
    Employee emp = (Employee)person;
    Console.WriteLine(emp.Company);
}
else
{
    Console.WriteLine("Преобразование не допустимо");
}