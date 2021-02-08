interface IMovable
{
    // константа
    const int minSpeed = 0;     // минимальная скорость
    // статическая переменная
    static int maxSpeed = 60;   // максимальная скорость
    // метод
    void Move();                // движение
    // свойство
    string Name { get; set; }   // название

    delegate void MoveHandler(string message);  // определение делегата для события
    // событие
    event MoveHandler MoveEvent;    // событие движения
}

static void Main(string[] args)
{
    Console.WriteLine(IMovable.maxSpeed);
    Console.WriteLine(IMovable.minSpeed);
}

interface IMovable
{
    public const int minSpeed = 0;     // минимальная скорость
    private static int maxSpeed = 60;   // максимальная скорость
    public void Move();
    protected internal string Name { get; set; }    // название
    public delegate void MoveHandler(string message);  // определение делегата для события
    public event MoveHandler MoveEvent;    // событие движения
}

interface IMovable
{
    // реализация метода по умолчанию
    void Move()
    {
        Console.WriteLine("Walking");
    }
}

interface IMovable
{
    void Move()
    {
        Console.WriteLine("Walking");
    }
    // реализация свойства по умолчанию
    // свойство только для чтения
    int MaxSpeed { get { return 0; } }
}

interface IMovable
{
    public const int minSpeed = 0;     // минимальная скорость
    private static int maxSpeed = 60;   // максимальная скорость
                                        // находим время, за которое надо пройти расстояние distance со скоростью speed
    static double GetTime(double distance, double speed) => distance / speed;
    static int MaxSpeed
    {
        get { return maxSpeed; }
        set
        {
            if (value > 0) maxSpeed = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IMovable.MaxSpeed);
        IMovable.MaxSpeed = 65;
        Console.WriteLine(IMovable.MaxSpeed);
        double time = IMovable.GetTime(100, 10);
        Console.WriteLine(time);
    }
}

public interface IMovable
{
    void Move();
}