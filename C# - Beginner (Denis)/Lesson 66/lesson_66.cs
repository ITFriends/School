int x = 5;
ref int xRef = ref x;

ref int xRef;   // ошибка

static void Main(string[] args)
{
    int x = 5;
    ref int xRef = ref x;
    Console.WriteLine(x); // 5
    xRef = 125;
    Console.WriteLine(x); // 125
    x = 625;
    Console.WriteLine(xRef); // 625

    Console.Read();
}

int a = 5;
int b = 8;
ref int pointer = ref a;
pointer = 34;
pointer = ref b;    // до версии 7.3 так делать было нельзя
pointer = 6;

static void Main(string[] args)
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
    ref int numberRef = ref Find(4, numbers); // ищем число 4 в массиве
    numberRef = 9; // заменяем 4 на 9
    Console.WriteLine(numbers[3]); // 9

    Console.Read();
}
static ref int Find(int number, int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == number)
        {
            return ref numbers[i]; // возвращаем ссылку на адрес, а не само значение
        }
    }
    throw new IndexOutOfRangeException("число не найдено");
}

return ref numbers[i];

ref int numberRef = ref Find(7, numbers);

static ref int Max(ref int n1, ref int n2)
{
    if (n1 > n2)
        return ref n1;
    else
        return ref n2;
}
static void Main(string[] args)
{
    int a = 5;
    int b = 8;
    ref int pointer = ref Max(ref a, ref b);
    pointer = 34;   // меняем значением максимального числа
    Console.WriteLine($"a: {a}  b: {b}"); // a: 5   b: 34

    Console.ReadKey();
}