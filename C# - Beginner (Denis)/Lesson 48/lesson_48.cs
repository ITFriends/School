class Program
{
    delegate void Message(); // 1. Объявляем делегат

    static void Main(string[] args)
    {
        Message mes; // 2. Создаем переменную делегата
        if (DateTime.Now.Hour < 12)
        {
            mes = GoodMorning; // 3. Присваиваем этой переменной адрес метода
        }
        else
        {
            mes = GoodEvening;
        }
        mes(); // 4. Вызываем метод
        Console.ReadKey();
    }
    private static void GoodMorning()
    {
        Console.WriteLine("Good Morning");
    }
    private static void GoodEvening()
    {
        Console.WriteLine("Good Evening");
    }
}

delegate void Message(); // 1. Объявляем делегат

Message mes; // 2. Создаем переменную делегата

mes(); // 4. Вызываем метод

class Program
{
    delegate int Operation(int x, int y);

    static void Main(string[] args)
    {
        // присваивание адреса метода через контруктор
        Operation del = Add; // делегат указывает на метод Add
        int result = del(4, 5); // фактически Add(4, 5)
        Console.WriteLine(result);

        del = Multiply; // теперь делегат указывает на метод Multiply
        result = del(4, 5); // фактически Multiply(4, 5)
        Console.WriteLine(result);

        Console.Read();
    }
    private static int Add(int x, int y)
    {
        return x + y;
    }
    private static int Multiply(int x, int y)
    {
        return x * y;
    }
}

class Math
{
    public int Sum(int x, int y) { return x + y; }
}
class Program
{
    delegate int Operation(int x, int y);

    static void Main(string[] args)
    {
        Math math = new Math();
        Operation del = math.Sum;
        int result = del(4, 5);     // math.Sum(4, 5)
        Console.WriteLine(result);  // 9

        Console.Read();
    }
}

class Program
{
    delegate int Operation(int x, int y);

    static void Main(string[] args)
    {
        Operation del = Add;
        Operation del2 = new Operation(Add);

        Console.Read();
    }
    private static int Add(int x, int y) { return x + y; }
}

delegate void SomeDel(int a, double b);

void SomeMethod1(int g, double n) { }

int SomeMethod2(int g, double n) { }
void SomeMethod3(double n, int g) { }
void SomeMethod4(ref int g, double n) { }
void SomeMethod5(out int g, double n) { g = 6; }

class Program
{
    delegate void Message();

    static void Main(string[] args)
    {
        Message mes1 = Hello;
        mes1 += HowAreYou;  // теперь mes1 указывает на два метода
        mes1(); // вызываются оба метода - Hello и HowAreYou
        Console.Read();
    }
    private static void Hello()
    {
        Console.WriteLine("Hello");
    }
    private static void HowAreYou()
    {
        Console.WriteLine("How are you?");
    }
}

Message mes1 = Hello;
mes1 += HowAreYou;
mes1 += Hello;
mes1 += Hello;

mes1();

static void Main(string[] args)
{
    Message mes1 = Hello;
    mes1 += HowAreYou;
    mes1(); // вызываются все методы из mes1
    mes1 -= HowAreYou;  // удаляем метод HowAreYou
    mes1(); // вызывается метод Hello

    Console.Read();
}

class Program
{
    delegate void Message();

    static void Main(string[] args)
    {
        Message mes1 = Hello;
        Message mes2 = HowAreYou;
        Message mes3 = mes1 + mes2; // объединяем делегаты
        mes3(); // вызываются все методы из mes1 и mes2

        Console.Read();
    }
    private static void Hello()
    {
        Console.WriteLine("Hello");
    }
    private static void HowAreYou()
    {
        Console.WriteLine("How are you?");
    }
}

class Program
{
    delegate int Operation(int x, int y);
    delegate void Message();

    static void Main(string[] args)
    {
        Message mes = Hello;
        mes();
        Operation op = Add;
        op(3, 4);
        Console.Read();
    }
    private static void Hello() { Console.WriteLine("Hello"); }
    private static int Add(int x, int y) { return x + y; }
}

class Program
{
    delegate int Operation(int x, int y);
    delegate void Message();

    static void Main(string[] args)
    {
        Message mes = Hello;
        mes.Invoke();
        Operation op = Add;
        op.Invoke(3, 4);
        Console.Read();
    }
    private static void Hello() { Console.WriteLine("Hello"); }
    private static int Add(int x, int y) { return x + y; }
}

Message mes = null;
//mes();        // ! Ошибка: делегат равен null

Operation op = Add;
op -= Add;      // делегат op пуст
op(3, 4);       // !Ошибка: делегат равен null

Message mes = null;
mes?.Invoke();        // ошибки нет, делегат просто не вызывается

Operation op = Add;
op -= Add;          // делегат op пуст
op?.Invoke(3, 4);   // ошибки нет, делегат просто не вызывается

class Program
{
    delegate int Operation(int x, int y);

    static void Main(string[] args)
    {
        Operation op = Subtract;
        op += Multiply;
        op += Add;
        Console.WriteLine(op(7, 2));    // Add(7,2) = 9
        Console.Read();
    }
    private static int Add(int x, int y) { return x + y; }
    private static int Subtract(int x, int y) { return x - y; }
    private static int Multiply(int x, int y) { return x * y; }
}

class Program
{
    delegate void GetMessage();

    static void Main(string[] args)
    {
        if (DateTime.Now.Hour < 12)
        {
            Show_Message(GoodMorning);
        }
        else
        {
            Show_Message(GoodEvening);
        }
        Console.ReadLine();
    }
    private static void Show_Message(GetMessage _del)
    {
        _del?.Invoke();
    }
    private static void GoodMorning()
    {
        Console.WriteLine("Good Morning");
    }
    private static void GoodEvening()
    {
        Console.WriteLine("Good Evening");
    }
}

delegate T Operation<T, K>(K val);

class Program
{
    static void Main(string[] args)
    {
        Operation<decimal, int> op = Square;

        Console.WriteLine(op(5));
        Console.Read();
    }

    static decimal Square(int n)
    {
        return n * n;
    }
}