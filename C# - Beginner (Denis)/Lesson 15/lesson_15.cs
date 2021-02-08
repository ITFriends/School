class Program
{
    static void Main(string[] args)
    {
        Sum(10, 15);        // параметры передаются по значению
        Console.ReadKey();
    }
    static int Sum(int x, int y)
    {
        return x + y;
    }
}

static void Main(string[] args)
{
    int x = 10;
    int y = 15;
    Addition(ref x, y); // вызов метода
    Console.WriteLine(x);   // 25

    Console.ReadLine();
}

// параметр x передается по ссылке
static void Addition(ref int x, int y)
{
    x += y;
}

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        Console.WriteLine($"Начальное значение переменной a = {a}");

        //Передача переменных по значению
        //После выполнения этого кода по-прежнему a = 5, так как мы передали лишь ее копию
        IncrementVal(a);
        Console.WriteLine($"Переменная a после передачи по значению равна = {a}");
        Console.ReadKey();
    }
    // передача по значению
    static void IncrementVal(int x)
    {
        x++;
        Console.WriteLine($"IncrementVal: {x}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        Console.WriteLine($"Начальное значение переменной a  = {a}");
        //Передача переменных по ссылке
        //После выполнения этого кода a = 6, так как мы передали саму переменную
        IncrementRef(ref a);
        Console.WriteLine($"Переменная a после передачи ссылке равна = {a}");

        Console.ReadKey();
    }
    // передача по ссылке
    static void IncrementRef(ref int x)
    {
        x++;
        Console.WriteLine($"IncrementRef: {x}");
    }
}

static void Sum(int x, int y, out int a)
{
    a = x + y;
}

static void Main(string[] args)
{
    int x = 10;

    int z;

    Sum(x, 15, out z);

    Console.WriteLine(z);

    Console.ReadKey();
}

static void Sum(int x, int y, out int a)
{
    Console.WriteLine(x + y);
}

static void Main(string[] args)
{
    int x = 10;
    int area;
    int perimetr;
    GetData(x, 15, out area, out perimetr);
    Console.WriteLine("Площадь : " + area);
    Console.WriteLine("Периметр : " + perimetr);

    Console.ReadKey();
}

static void GetData(int x, int y, out int area, out int perim)
{
    area = x * y;
    perim = (x + y) * 2;
}

int x = 10;
int area;
int perimetr;
GetData(x, 15, out area, out perimetr);
Console.WriteLine($"Площадь : {area}");
Console.WriteLine($"Периметр : {perimetr}");


int x = 10;
GetData(x, 15, out int area, out int perimetr);
Console.WriteLine($"Площадь : {area}");
Console.WriteLine($"Периметр : {perimetr}");

static void GetData(in int x, int y, out int area, out int perim)
{
    // x = x + 10; нельзя изменить значение параметра x
    y = y + 10;
    area = x * y;
    perim = (x + y) * 2;
}
