var user = new { Name = "Tom", Age = 34 };
Console.WriteLine(user.Name);

var user = new { Name = "Tom", Age = 34 };
var student = new { Name = "Alice", Age = 21 };
var manager = new { Name = "Bob", Age = 26, Company = "Microsoft" };

Console.WriteLine(user.GetType().Name); // <>f__AnonymousType0'2
Console.WriteLine(student.GetType().Name); // <>f__AnonymousType0'2
Console.WriteLine(manager.GetType().Name); // <>f__AnonymousType1'3

var student = new { Name = "Alice", Age = 21 };
student.Age = 32;   // ! Ошибка

class User
{
    public string Name { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        User tom = new User { Name = "Tom" };
        int age = 34;
        var student = new { tom.Name, age }; // инициализатор с проекцией
        Console.WriteLine(student.Name);
        Console.WriteLine(student.age);
        Console.Read();
    }
}

var student = new { Name = tom.Name, age = age };

var people = new[]
{
    new {Name="Tom"},
    new {Name="Bob"}
};
foreach (var p in people)
{
    Console.WriteLine(p.Name);
}