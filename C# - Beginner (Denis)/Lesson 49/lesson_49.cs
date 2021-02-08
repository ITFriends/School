delegate (параметры)
{
    // инструкции
}

class Program
{
    delegate void MessageHandler(string message);
    static void Main(string[] args)
    {
        MessageHandler handler = delegate (string mes)
        {
            Console.WriteLine(mes);
        };
        handler("hello world!");

        Console.Read();
    }
}

class Program
{
    delegate void MessageHandler(string message);
    static void Main(string[] args)
    {
        ShowMessage("hello!", delegate (string mes)
        {
            Console.WriteLine(mes);
        });

        Console.Read();
    }
    static void ShowMessage(string mes, MessageHandler handler)
    {
        handler(mes);
    }
}

class Program
{
    delegate void MessageHandler(string message);
    static void Main(string[] args)
    {
        MessageHandler handler = delegate
        {
            Console.WriteLine("анонимный метод");
        };
        handler("hello world!");    // анонимный метод

        Console.Read();
    }
}

delegate int Operation(int x, int y);
static void Main(string[] args)
{
    Operation operation = delegate (int x, int y)
    {
        return x + y;
    };
    int d = operation(4, 5);
    Console.WriteLine(d);       // 9
    Console.Read();
}

delegate int Operation(int x, int y);
static void Main(string[] args)
{
    int z = 8;
    Operation operation = delegate (int x, int y)
    {
        return x + y + z;
    };
    int d = operation(4, 5);
    Console.WriteLine(d);       // 17
    Console.Read();
}