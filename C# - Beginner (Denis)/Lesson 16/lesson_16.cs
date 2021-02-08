static void Addition(params int[] integers)
{
    int result = 0;
    for (int i = 0; i < integers.Length; i++)
    {
        result += integers[i];
    }
    Console.WriteLine(result);
}

static void Main(string[] args)
{
    Addition(1, 2, 3, 4, 5);

    int[] array = new int[] { 1, 2, 3, 4 };
    Addition(array);

    Addition();
    Console.ReadLine();
}

//Так работает
static void Addition(int x, string mes, params int[] integers)
{ }

Addition(2, "hello", 1, 3, 4);

//Так НЕ работает
static void Addition(params int[] integers, int x, string mes)
{ }

// передача параметра с params
static void Addition(params int[] integers)
{
    int result = 0;
    for (int i = 0; i < integers.Length; i++)
    {
        result += integers[i];
    }
    Console.WriteLine(result);
}
// передача массива
static void AdditionMas(int[] integers, int k)
{
    int result = 0;
    for (int i = 0; i < integers.Length; i++)
    {
        result += (integers[i] * k);
    }
    Console.WriteLine(result);
}

static void Main(string[] args)
{
    Addition(1, 2, 3, 4, 5);

    int[] array = new int[] { 1, 2, 3, 4 };
    AdditionMas(array, 2);

    Console.ReadLine();
}
