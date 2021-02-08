namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(4);
        }
    }
    class Account
    {
        public int Id { get; private set; } // номер счета
        public Account(int _id)
        {
            Id = _id;
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
            Console.WriteLine("hello");
        }
    }
}

static void Main(string[] args)
{
    System.Console.WriteLine("hello");
}

using HelloApp.AccountSpace;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(4);
        }
    }

    namespace AccountSpace
    {
        class Account
        {
            public int Id { get; private set; }
            public Account(int _id)
            {
                Id = _id;
            }
        }
    }
}

using printer = System.Console;
class Program
{
    static void Main(string[] args)
    {
        printer.WriteLine("Hello from C#");
        printer.Read();
    }
}

using Person = HelloApp.User;
using Printer = System.Console;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Tom";
            Printer.WriteLine(person.name);
            Printer.Read();
        }
    }

    class User
    {
        public string name;
    }
}

using static System.Console;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello from C# 8.0");
            Read();
        }
    }
}

using static System.Console;
using static System.Math;
using static HelloApp.Geometry;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 50;
            double result = GetArea(radius); //Geometry.GetArea
            WriteLine(result); //Console.WriteLine
            Read(); // Console.Read
        }
    }

    class Geometry
    {
        public static double GetArea(double radius)
        {
            return PI * radius * radius; // Math.PI
        }
    }
}