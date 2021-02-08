class Counter
{
    public int Value { get; set; }
}

Counter c1 = new Counter { Value = 23 };
Counter c2 = new Counter { Value = 45 };

bool result = c1 > c2;
Counter c3 = c1 + c2;

public static возвращаемый_тип operator оператор(параметры)
{ }

class Counter
{
    public int Value { get; set; }

    public static Counter operator +(Counter c1, Counter c2)
    {
        return new Counter { Value = c1.Value + c2.Value };
    }
    public static bool operator >(Counter c1, Counter c2)
    {
        return c1.Value > c2.Value;
    }
    public static bool operator <(Counter c1, Counter c2)
    {
        return c1.Value < c2.Value;
    }
}

public static Counter operator +(Counter c1, Counter c2)
{
    return new Counter { Value = c1.Value + c2.Value };
}

static void Main(string[] args)
{
    Counter c1 = new Counter { Value = 23 };
    Counter c2 = new Counter { Value = 45 };
    bool result = c1 > c2;
    Console.WriteLine(result); // false

    Counter c3 = c1 + c2;
    Console.WriteLine(c3.Value);  // 23 + 45 = 68

    Console.ReadKey();
}

public static int operator +(Counter c1, int val)
{
    return c1.Value + val;
}

Counter c1 = new Counter { Value = 23 };
int d = c1 + 27; // 50
Console.WriteLine(d);

public static Counter operator ++(Counter c1)
{
    c1.Value += 10;
    return c1;
}

public static Counter operator ++(Counter c1)
{
    return new Counter { Value = c1.Value + 10 };
}

Counter counter = new Counter() { Value = 10 };
Console.WriteLine($"{counter.Value}");      // 10
Console.WriteLine($"{(++counter).Value}");  // 20
Console.WriteLine($"{counter.Value}");      // 20

Counter counter = new Counter() { Value = 10 };
Console.WriteLine($"{counter.Value}");      // 10
Console.WriteLine($"{(counter++).Value}");  // 10
Console.WriteLine($"{counter.Value}");      // 20
Консольный вывод:

class Counter
{
    public int Value { get; set; }

    public static bool operator true(Counter c1)
    {
        return c1.Value != 0;
    }
    public static bool operator false(Counter c1)
    {
        return c1.Value == 0;
    }

    // остальное содержимое класса
}

Counter counter = new Counter() { Value = 0 };
if (counter)
    Console.WriteLine(true);
else
    Console.WriteLine(false);