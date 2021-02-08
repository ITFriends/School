class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person { Name = "Tom", Age = 23 };
        Person p2 = p1;
        p2.Name = "Alice";
        Console.WriteLine(p1.Name); // Alice

        Console.Read();
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public interface ICloneable
{
    object Clone();
}

class Person : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public object Clone()
    {
        return new Person { Name = this.Name, Age = this.Age };
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person { Name = "Tom", Age = 23 };
        Person p2 = (Person)p1.Clone();
        p2.Name = "Alice";
        Console.WriteLine(p1.Name); // Tom

        Console.Read();
    }
}

class Person : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}

class Person : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Company Work { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}

class Company
{
    public string Name { get; set; }
}

Person p1 = new Person { Name = "Tom", Age = 23, Work = new Company { Name = "Microsoft" } };
Person p2 = (Person)p1.Clone();
p2.Work.Name = "Google";
p2.Name = "Alice";
Console.WriteLine(p1.Name); // Tom
Console.WriteLine(p1.Work.Name); // Google - а должно быть Microsoft

class Person : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Company Work { get; set; }

    public object Clone()
    {
        Company company = new Company { Name = this.Work.Name };
        return new Person
        {
            Name = this.Name,
            Age = this.Age,
            Work = company
        };
    }
}

class Company
{
    public string Name { get; set; }
}