class Program
{
    delegate int Operation(int x, int y);
    static void Main(string[] args)
    {
        Operation operation = (x, y) => x + y;
        Console.WriteLine(operation(10, 20));       // 30
        Console.WriteLine(operation(40, 20));       // 60
        Console.Read();
    }
}

class Program
{
    delegate int Square(int x); // объявляем делегат, принимающий int и возвращающий int
    static void Main(string[] args)
    {
        Square square = i => i * i; // объекту делегата присваивается лямбда-выражение

        int z = square(6); // используем делегат
        Console.WriteLine(z); // выводит число 36
        Console.Read();
    }
}

class Program
{
    delegate void Hello(); // делегат без параметров
    static void Main(string[] args)
    {
        Hello hello1 = () => Console.WriteLine("Hello");
        Hello hello2 = () => Console.WriteLine("Welcome");
        hello1();       // Hello
        hello2();       // Welcome
        Console.Read();
    }
}

class Program
{
    delegate void ChangeHandler(ref int x);
    static void Main(string[] args)
    {
        int x = 9;
        ChangeHandler ch = (ref int n) => n = n * 2;
        ch(ref x);
        Console.WriteLine(x);   // 18
        Console.Read();
    }
}

class Program
{
    delegate void Hello(); // делегат без параметров
    static void Main(string[] args)
    {
        Hello message = () => Show_Message();
        message();
    }
    private static void Show_Message()
    {
        Console.WriteLine("Привет мир!");
    }
}

class Program
{
    delegate bool IsEqual(int x);

    static void Main(string[] args)
    {
        int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // найдем сумму чисел больше 5
        int result1 = Sum(integers, x => x > 5);
        Console.WriteLine(result1); // 30

        // найдем сумму четных чисел
        int result2 = Sum(integers, x => x % 2 == 0);
        Console.WriteLine(result2);  //20

        Console.Read();
    }

    private static int Sum(int[] numbers, IsEqual func)
    {
        int result = 0;
        foreach (int i in numbers)
        {
            if (func(i))
                result += i;
        }
        return result;
    }
}

int result1 = Sum(integers, x => x > 5);

int result2 = Sum(integers, x => x % 2 == 0);