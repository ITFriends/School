enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum Time : byte
{
    Morning,
    Afternoon,
    Evening,
    Night
}

enum Operation
{
    Add = 1,   // каждый следующий элемент по умолчанию увеличивается на единицу
    Subtract, // этот элемент равен 2
    Multiply, // равен 3
    Divide    // равен 4
}

enum Operation
{
    Add = 2,
    Subtract = 4,
    Multiply = 8,
    Divide = 16
}

enum Color
{
    White = 1,
    Black = 2,
    Green = 2,
    Blue = White // Blue = 1
}

enum Operation
{
    Add = 1,
    Subtract,
    Multiply,
    Divide
}
class Program
{
    static void Main(string[] args)
    {
        Operation op;
        op = Operation.Add;
        Console.WriteLine(op); // Add

        Console.ReadLine();
    }
}

Operation op;
op = Operation.Multiply;

enum Operation
{
    Add = 1,
    Subtract,
    Multiply,
    Divide
}
class Program
{
    static void Main(string[] args)
    {
        Operation op;
        op = Operation.Add;
        Console.WriteLine(op); // Add

        Console.ReadLine();
    }
}

class Program
{
    enum Operation
    {
        Add = 1,
        Subtract,
        Multiply,
        Divide
    }

    static void MathOp(double x, double y, Operation op)
    {
        double result = 0.0;

        switch (op)
        {
            case Operation.Add:
                result = x + y;
                break;
            case Operation.Subtract:
                result = x - y;
                break;
            case Operation.Multiply:
                result = x * y;
                break;
            case Operation.Divide:
                result = x / y;
                break;
        }

        Console.WriteLine("Результат операции равен {0}", result);
    }

    static void Main(string[] args)
    {
        // Тип операции задаем с помощью константы Operation.Add, которая равна 1
        MathOp(10, 5, Operation.Add);
        // Тип операции задаем с помощью константы Operation.Multiply, которая равна 3
        MathOp(11, 5, Operation.Multiply);

        Console.ReadLine();
    }
}