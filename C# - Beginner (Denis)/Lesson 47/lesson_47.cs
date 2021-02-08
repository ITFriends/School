using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestClass.Method1();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Catch в Main : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally в Main");
            }
            Console.WriteLine("Конец метода Main");
            Console.Read();
        }
    }
    class TestClass
    {
        public static void Method1()
        {
            try
            {
                Method2();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Catch в Method1 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally в Method1");
            }
            Console.WriteLine("Конец метода Method1");
        }
        static void Method2()
        {
            try
            {
                int x = 8;
                int y = x / 0;
            }
            finally
            {
                Console.WriteLine("Блок finally в Method2");
            }
            Console.WriteLine("Конец метода Method2");
        }
    }
}

try
{
    int x = 8;
int y = x / 0;
}
finally
{
    Console.WriteLine("Блок finally в Method2");
}

try
{
    Method2();
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Catch в Method1 : {ex.Message}");
}
finally
{
    Console.WriteLine("Блок finally в Method1");
}

try
{
    TestClass.Method1();
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Catch в Main : {ex.Message}");
}
finally
{
    Console.WriteLine("Блок finally в Main");
}

finally
{
    Console.WriteLine("Блок finally в Method2");
}

finally
{
    Console.WriteLine("Блок finally в Method1");
}

catch (DivideByZeroException ex)
{
    Console.WriteLine($"Catch в Main : {ex.Message}");
}
finally
{
    Console.WriteLine("Блок finally в Main");
}