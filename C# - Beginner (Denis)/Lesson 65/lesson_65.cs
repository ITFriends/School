int? z = null;
bool? enabled = null;

int? z1 = 5;
bool? enabled1 = null;
Double? d1 = 3.3;

Nullable<int> z2 = 5;
Nullable<bool> enabled2 = null;
Nullable<System.Double> d2 = 3.3;

class Program
{
    static void Main(string[] args)
    {
        int? x = 7;
        Console.WriteLine(x.Value); // 7
        Nullable<State> state = new State() { Name = "Narnia" };
        Console.WriteLine(state.Value.Name);    // Narnia

        Console.ReadLine();
    }
}
struct State
{
    public string Name { get; set; }
}

int? x = null;
Console.WriteLine(x.Value); // Ошибка
State? state = null;
Console.WriteLine(state.Value.Name);    // ошибка

int? x = null;
if (x.HasValue)
    Console.WriteLine(x.Value);
else
    Console.WriteLine("x is equal to null");

State? state = null;
if (state.HasValue)
    Console.WriteLine(state.Value.Name);
else
    Console.WriteLine("state is equal to null");

class Program
{
    static void Main(string[] args)
    {
        Nullable<State> state = null; // State - значимый тип
                                      // Nullable<Country> country = null;  Ошибка - Country - ссылочный тип

        Console.ReadLine();
    }
}
class Country
{
    public string Name { get; set; }
}
struct State
{
    public string Name { get; set; }
}

int? figure = null;
Console.WriteLine(figure.GetValueOrDefault()); // по умолчанию используется 0
Console.WriteLine(figure.GetValueOrDefault(10)); // по умолчанию используется 10

int? x1 = null;
int? x2 = null;
if (x1 == x2)
    Console.WriteLine("объекты равны");
else
    Console.WriteLine("объекты не равны");

int? x1 = null;
if (x1.HasValue)
{
    int x2 = (int)x1;
    Console.WriteLine(x2);
}

int x1 = 4;
int? x2 = x1;
Console.WriteLine(x2);

int x1 = 4;
long? x2 = x1;
Console.WriteLine(x2);

long x1 = 4;
int? x2 = (int?)x1;

long? x1 = 4;
int? x2 = (int?)x1;

long? x1 = 4;
int x2 = (int)x1;