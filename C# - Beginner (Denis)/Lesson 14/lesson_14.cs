
static void Main(string[] args)
{

}

using System;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        static void SayGoodbye()
        {
            Console.WriteLine("GoodBye");
        }
    }
}

using System;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayGoodbye();

            Console.ReadKey();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        static void SayGoodbye()
        {
            Console.WriteLine("GoodBye");
        }
    }
}

static string GetHello()
{
    return "Hello";
}
static int GetSum()
{
    int x = 2;
    int y = 3;
    int z = x + y;
    return z;
}


static int GetSum()
{
    int x = 2;
    int y = 3;
    return x + y;
}

static string GetHello()
{
    Console.WriteLine("Hello");
}
static int GetSum()
{
    int x = 2;
    int y = 3;
    return "5"; // ошибка - надо возвращать число
}


using System;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = GetHello();
            int sum = GetSum();

            Console.WriteLine(message);  // Hello
            Console.WriteLine(sum);     // 5

            Console.ReadKey();
        }

        static string GetHello()
        {
            return "Hello";
        }
        static int GetSum()
        {
            int x = 2;
            int y = 3;
            return x + y;
        }
    }
}


static string GetHello()
{
    return "Hello";
    Console.WriteLine("After return");
}


static void SayHello()
{
    int hour = 23;
    if (hour > 22)
    {
        return;
    }
    else
    {
        Console.WriteLine("Hello");
    }
}

static void SayHello()
{
    Console.WriteLine("Hello");
}


static void SayHello() => Console.WriteLine("Hello");


static string GetHello()
{
    return "hello";
}

static string GetHello() => "hello";