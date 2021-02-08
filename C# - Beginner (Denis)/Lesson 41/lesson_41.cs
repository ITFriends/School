class Account
{
    public int Id { get; set; }
    public int Sum { get; set; }
}

class Account
{
    public object Id { get; set; }
    public int Sum { get; set; }
}

Account account1 = new Account { Sum = 5000 };
Account account2 = new Account { Sum = 4000 };
account1.Id = 2;
account2.Id = "4356";
int id1 = (int)account1.Id;
string id2 = (string)account2.Id;
Console.WriteLine(id1);
Console.WriteLine(id2);

account1.Id = 2;        // упаковка в значения int в тип Object

int id1 = (int)account1.Id;     // Распаковка в тип int

Account account2 = new Account { Sum = 4000 };
account2.Id = "4356";
int id2 = (int)account2.Id;     // Исключение InvalidCastException

class Account<T>
{
    public T Id { get; set; }
    public int Sum { get; set; }
}

Account<int> account1 = new Account<int> { Sum = 5000 };
Account<string> account2 = new Account<string> { Sum = 4000 };
account1.Id = 2;        // упаковка не нужна
account2.Id = "4356";
int id1 = account1.Id;  // распаковка не нужна
string id2 = account2.Id;
Console.WriteLine(id1);
Console.WriteLine(id2);

Account<int> account1 = new Account<int> { Sum = 5000 };
Account<string> account2 = new Account<string> { Sum = 4000 };

Account<string> account2 = new Account<string> { Sum = 4000 };
account2.Id = "4356";
int id1 = account2.Id;  // ошибка компиляции

class Account<T>
{
    T id = default(T);
}

class Account<T>
{
    public static T session;

    public T Id { get; set; }
    public int Sum { get; set; }
}

Account<int> account1 = new Account<int> { Sum = 5000 };
Account<int>.session = 5436;

Account<string> account2 = new Account<string> { Sum = 4000 };
Account<string>.session = "45245";

Console.WriteLine(Account<int>.session);      // 5436
Console.WriteLine(Account<string>.session);   // 45245

class Transaction<U, V>
{
    public U FromAccount { get; set; }  // с какого счета перевод
    public U ToAccount { get; set; }    // на какой счет перевод
    public V Code { get; set; }         // код операции
    public int Sum { get; set; }        // сумма перевода
}

Account<int> acc1 = new Account<int> { Id = 1857, Sum = 4500 };
Account<int> acc2 = new Account<int> { Id = 3453, Sum = 5000 };

Transaction<Account<int>, string> transaction1 = new Transaction<Account<int>, string>
{
    FromAccount = acc1,
    ToAccount = acc2,
    Code = "45478758",
    Sum = 900
};

class Program
{
    private static void Main(string[] args)
    {
        int x = 7;
        int y = 25;
        Swap<int>(ref x, ref y); // или так Swap(ref x, ref y);
        Console.WriteLine($"x={x}    y={y}");   // x=25   y=7

        string s1 = "hello";
        string s2 = "bye";
        Swap<string>(ref s1, ref s2); // или так Swap(ref s1, ref s2);
        Console.WriteLine($"s1={s1}    s2={s2}"); // s1=bye   s2=hello

        Console.Read();
    }
    public static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
}