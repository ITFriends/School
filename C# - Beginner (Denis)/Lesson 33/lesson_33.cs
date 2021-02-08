class Person
{
    public string Name { get; set; }
}
class People
{
    Person[] data;
    public People()
    {
        data = new Person[5];
    }
    // индексатор
    public Person this[int index]
    {
        get
        {
            return data[index];
        }
        set
        {
            data[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        People people = new People();
        people[0] = new Person { Name = "Tom" };
        people[1] = new Person { Name = "Bob" };

        Person tom = people[0];
        Console.WriteLine(tom?.Name);

        Console.ReadKey();
    }
}

class User
{
    string name;
    string email;
    string phone;

    public string this[string propname]
    {
        get
        {
            switch (propname)
            {
                case "name": return "Mr/Ms. " + name;
                case "email": return email;
                case "phone": return phone;
                default: return null;
            }
        }
        set
        {
            switch (propname)
            {
                case "name":
                    name = value;
                    break;
                case "email":
                    email = value;
                    break;
                case "phone":
                    phone = value;
                    break;
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        User tom = new User();
        tom["name"] = "Tom";
        tom["email"] = "tomekvilmovskiy@gmail.ru";

        Console.WriteLine(tom["name"]); // Mr/Ms. Tom

        Console.ReadKey();
    }
}

class Matrix
{
    private int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };
    public int this[int i, int j]
    {
        get
        {
            return numbers[i, j];
        }
        set
        {
            numbers[i, j] = value;
        }
    }
}

Matrix matrix = new Matrix();
Console.WriteLine(matrix[0, 0]);
matrix[0, 0] = 111;
Console.WriteLine(matrix[0, 0]);

class Matrix
{
    private int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };
    public int this[int i, int j]
    {
        get
        {
            return numbers[i, j];
        }
    }
}

class Matrix
{
    private int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };
    public int this[int i, int j]
    {
        get
        {
            return numbers[i, j];
        }
        private set
        {
            numbers[i, j] = value;
        }
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class People
{
    Person[] data;
    public People()
    {
        data = new Person[5];
    }
    public Person this[int index]
    {
        get
        {
            return data[index];
        }
        set
        {
            data[index] = value;
        }
    }
    public Person this[string name]
    {
        get
        {
            Person person = null;
            foreach (var p in data)
            {
                if (p?.Name == name)
                {
                    person = p;
                    break;
                }
            }
            return person;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        People people = new People();
        people[0] = new Person { Name = "Tom" };
        people[1] = new Person { Name = "Bob" };

        Console.WriteLine(people[0].Name);      // Tom
        Console.WriteLine(people["Bob"].Name);  // Bob

        Console.ReadKey();
    }
}