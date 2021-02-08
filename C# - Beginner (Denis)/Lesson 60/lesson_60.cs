public partial class Person
{
    public void Move()
    {
        Console.WriteLine("I am moving");
    }
}

public partial class Person
{
    public void Eat()
    {
        Console.WriteLine("I am eating");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person tom = new Person();
        tom.Move();
        tom.Eat();

        Console.ReadKey();
    }
}

public partial class Person
{
    partial void DoSomethingElse();

    public void DoSomething()
    {
        Console.WriteLine("Start");
        DoSomethingElse();
        Console.WriteLine("Finish");
    }
}

public partial class Person
{
    partial void DoSomethingElse()
    {
        Console.WriteLine("I am reading a book");
    }
}