class Program
{
    static void Main(string[] args)
    {
        try
        {
            Person p = new Person { Name = "Tom", Age = 17 };
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        Console.Read();
    }
}
class Person
{
    private int age;
    public string Name { get; set; }
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
            {
                throw new Exception("Лицам до 18 регистрация запрещена");
            }
            else
            {
                age = value;
            }
        }
    }
}

class PersonException : Exception
{
    public PersonException(string message)
        : base(message)
    { }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Person p = new Person { Name = "Tom", Age = 17 };
        }
        catch (PersonException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        Console.Read();
    }
}
class Person
{
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
                throw new PersonException("Лицам до 18 регистрация запрещена");
            else
                age = value;
        }
    }
}

class PersonException : ArgumentException
{
    public PersonException(string message)
        : base(message)
    { }
}

class PersonException : ArgumentException
{
    public int Value { get; }
    public PersonException(string message, int val)
        : base(message)
    {
        Value = val;
    }
}

class Person
{
    public string Name { get; set; }
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
                throw new PersonException("Лицам до 18 регистрация запрещена", value);
            else
                age = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Person p = new Person { Name = "Tom", Age = 13 };
        }
        catch (PersonException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
            Console.WriteLine($"Некорректное значение: {ex.Value}");
        }
        Console.Read();
    }
}