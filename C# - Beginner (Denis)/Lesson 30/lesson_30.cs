const double PI = 3.14;
const double E = 2.71;

class MathLib
{
    public const double PI = 3.141;
    public const double E = 2.81;
    public const double K;      // Ошибка, константа не инициализирована
}

class Program
{
    static void Main(string[] args)
    {
        MathLib.E = 3.8; // Ошибка, значение константы нельзя изменить
    }
}

class MathLib
{
    public const double PI = 3.141;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MathLib.PI);
    }
}

class MathLib
{
    public double GetCircleArea(double radius)
    {
        const double PI = 3.141;
        return PI * radius * radius;
    }
}

class MathLib
{
    public readonly double K = 23;  // можно так инициализировать

    public MathLib(double _k)
    {
        K = _k; // поле для чтения может быть инициализировано или изменено в конструкторе после компиляции
    }
    public void ChangeField()
    {
        // так нельзя
        //K = 34;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MathLib mathLib = new MathLib(3.8);
        Console.WriteLine(mathLib.K); // 3.8

        //mathLib.K = 7.6; // поле для чтения нельзя установить вне своего класса
        Console.ReadLine();

    }
}

readonly struct User { }

readonly struct User
{
    public readonly string name;
    public User(string name)
    {
        this.name = name;
    }
}

readonly struct User
{
    public readonly string Name { get; } // указывать readonly необязательно
    public int Age { get; } // свойство только для чтения
    public User(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}