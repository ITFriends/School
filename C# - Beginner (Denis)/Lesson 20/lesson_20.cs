var tuple = (5, 10);

static void Main(string[] args)
{
    var tuple = (5, 10);
    Console.WriteLine(tuple.Item1); // 5
    Console.WriteLine(tuple.Item2); // 10
    tuple.Item1 += 26;
    Console.WriteLine(tuple.Item1); // 31
    Console.Read();
}

(int, int) tuple = (5, 10);

(string, int, double) person = ("Tom", 25, 81.23);

var tuple = (count: 5, sum: 10);
Console.WriteLine(tuple.count); // 5
Console.WriteLine(tuple.sum); // 10

static void Main(string[] args)
{
    var (name, age) = ("Tom", 23);
    Console.WriteLine(name);    // Tom
    Console.WriteLine(age);     // 23
    Console.Read();
}

static void Main(string[] args)
{
    var tuple = GetValues();
    Console.WriteLine(tuple.Item1); // 1
    Console.WriteLine(tuple.Item2); // 3

    Console.Read();
}
private static (int, int) GetValues()
{
    var result = (1, 3);
    return result;
}

static void Main(string[] args)
{
    var tuple = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });
    Console.WriteLine(tuple.count);
    Console.WriteLine(tuple.sum);

    Console.Read();
}
private static (int sum, int count) GetNamedValues(int[] numbers)
{
    var result = (sum: 0, count: 0);
    for (int i = 0; i < numbers.Length; i++)
    {
        result.sum += numbers[i];
        result.count++;
    }
    return result;
}

static void Main(string[] args)
{
    var (name, age) = GetTuple(("Tom", 23), 12);
    Console.WriteLine(name);    // Tom
    Console.WriteLine(age);     // 35
    Console.Read();
}

private static (string name, int age) GetTuple((string n, int a) tuple, int x)
{
    var result = (name: tuple.n, age: tuple.a + x);
    return result;
}