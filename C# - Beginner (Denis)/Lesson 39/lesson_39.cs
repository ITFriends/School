abstract class Human
{
    public int Length { get; set; }
    public double Weight { get; set; }
}

Human h = new Human();

abstract class Person
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

class Client : Person
{
    public int Sum { get; set; }    // сумма на счету

    public Client(string name, int sum)
        : base(name)
    {
        Sum = sum;
    }
}

class Employee : Person
{
    public string Position { get; set; } // должность

    public Employee(string name, string position)
        : base(name)
    {
        Position = position;
    }
}

Client client = new Client("Tom", 500);
Employee employee = new Employee("Bob", "Apple");
client.Display();
employee.Display();
Или даже так:

1
2
Person client = new Client("Tom", 500);
Person employee = new Employee("Bob", "Операционист");
Но мы НЕ можем создать объект Person, используя конструктор класса Person:

1
Person person = new Person("Bill");

abstract class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public abstract void Display();
}

class Client : Person
{
    public int Sum { get; set; }    // сумма на счету

    public Client(string name, int sum)
        : base(name)
    {
        Sum = sum;
    }
    public override void Display()
    {
        Console.WriteLine($"{Name} имеет счет на сумму {Sum}");
    }
}

class Employee : Person
{
    public string Position { get; set; } // должность

    public Employee(string name, string position)
        : base(name)
    {
        Position = position;
    }

    public override void Display()
    {
        Console.WriteLine($"{Position} {Name}");
    }
}

abstract class Person
{
    public abstract string Name { get; set; }
}

class Client : Person
{
    private string name;

    public override string Name
    {
        get { return "Mr/Ms. " + name; }
        set { name = value; }
    }
}

class Employee : Person
{
    public override string Name { get; set; }
}

abstract class Person
{
    public abstract string Name { get; set; }
}

abstract class Manager : Person
{
}

// абстрактный класс фигуры
abstract class Figure
{
    // абстрактный метод для получения периметра
    public abstract float Perimeter();
    // абстрактный метод для получения площади
    public abstract float Area();
}
// производный класс прямоугольника
class Rectangle : Figure
{
    public float Width { get; set; }
    public float Height { get; set; }

    public Rectangle(float width, float height)
    {
        this.Width = width;
        this.Height = height;
    }
    // переопределение получения периметра
    public override float Perimeter()
    {
        return Width * 2 + Height * 2;
    }
    // переопрелеление получения площади
    public override float Area()
    {
        return Width * Height;
    }
}