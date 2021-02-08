﻿int x = 50;
byte y = (byte)x; // явное преобразование от int к byte
int z = y;  // неявное преобразование от byte к int

public static implicit|explicit operator Тип_в_который_надо_преобразовать(исходный_тип param)
{
    // логика преобразования
}

class Counter
{
    public int Seconds { get; set; }

    public static implicit operator Counter(int x)
    {
        return new Counter { Seconds = x };
    }
    public static explicit operator int(Counter counter)
    {
        return counter.Seconds;
    }
}

static void Main(string[] args)
{
    Counter counter1 = new Counter { Seconds = 23 };

    int x = (int)counter1;
    Console.WriteLine(x);   // 23

    Counter counter2 = x;
    Console.WriteLine(counter2.Seconds);  // 23
}

class Timer
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
}
class Counter
{
    public int Seconds { get; set; }

    public static implicit operator Counter(int x)
    {
        return new Counter { Seconds = x };
    }
    public static explicit operator int(Counter counter)
    {
        return counter.Seconds;
    }
    public static explicit operator Counter(Timer timer)
    {
        int h = timer.Hours * 3600;
        int m = timer.Minutes * 60;
        return new Counter { Seconds = h + m + timer.Seconds };
    }
    public static implicit operator Timer(Counter counter)
    {
        int h = counter.Seconds / 3600;
        int m = (counter.Seconds % 3600) / 60;
        int s = counter.Seconds % 60;
        return new Timer { Hours = h, Minutes = m, Seconds = s };
    }
}

static void Main(string[] args)
{
    Counter counter1 = new Counter { Seconds = 115 };

    Timer timer = counter1;
    Console.WriteLine($"{timer.Hours}:{timer.Minutes}:{timer.Seconds}"); // 0:1:55

    Counter counter2 = (Counter)timer;
    Console.WriteLine(counter2.Seconds);  //115

    Console.ReadKey();
}